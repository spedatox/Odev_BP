using Odev_BP;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

public class Log
{
    [Key]
    public int LogId { get; set; }

    public DateTime LogTime { get; set; }
    public string Message { get; set; }
   
}

public static class Logger
{
    private static readonly string LogFilePath = "C:\\Users\\speda\\OneDrive\\Masaüstü\\Odev_BP\\otel_log.txt";

    public static void Log(string message)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(LogFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now} - {message}");
            }

            
            using (var dbContext = new OtelDbContext()) 
            {
                var log = new Log
                {
                    LogTime = DateTime.Now,
                    Message = message
                };

                dbContext.Add(log);
                dbContext.SaveChanges();
            }
        }
        catch (Exception ex)
        {
            
            Console.WriteLine($"Loglama hatası: {ex.Message}");
        }
    }
}
