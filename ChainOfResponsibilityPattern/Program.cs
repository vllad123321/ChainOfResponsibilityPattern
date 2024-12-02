using System;
using ChainOfResponsibilityPattern.Handlers;
using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Создаем обработчики
            var errorHandler = new ErrorHandler();
            var warningHandler = new WarningHandler();
            var infoHandler = new InfoHandler();

            // Собираем цепочку
            infoHandler.SetNext(warningHandler);
            warningHandler.SetNext(errorHandler);

            // Создаем запросы
            var requests = new[]
            {
                new Request(RequestType.Info, "Информационное сообщение."),
                new Request(RequestType.Warning, "Предупреждение."),
                new Request(RequestType.Error, "Ошибка!")
            };

            // Обрабатываем запросы
            foreach (var request in requests)
            {
                Console.WriteLine($"Обработка запроса типа {request.Type}...");
                infoHandler.Handle(request);
                Console.WriteLine();
            }
        }
    }
}
