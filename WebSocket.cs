﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;

namespace ModReguestWebsocket
{
    public class WebSocket
    {
        public static async Task PostRequestAsync()
        {
            WebRequest request = WebRequest.Create("wss://fstream.binance.com");
            request.Method = "POST"; // для отправки используется метод Post
                                     // данные для отправки
            string data = "btcusdt@depth";
            // преобразуем данные в массив байтов
            byte[] byteArray = Encoding.UTF8.GetBytes(data);
            // устанавливаем тип содержимого - параметр ContentType
            request.ContentType = "application/x-www-form-urlencoded";
            // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
            request.ContentLength = byteArray.Length;

            //записываем данные в поток запроса
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            WebResponse response = await request.GetResponseAsync();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    //Console.WriteLine(reader.ReadToEnd());
                }
            }
            response.Close();
            //Console.WriteLine("Запрос выполнен...");
        }
    }
}