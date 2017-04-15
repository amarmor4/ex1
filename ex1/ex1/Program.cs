﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchAlgorithmsLib;
using MazeLib;
using MazeGeneratorLib;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller c = new Controller();
            IClientHandler ch = new ClientHandler(c);
            Server server = new Server(8000, ch);
            c.setView(server);
            IModel m = new MazeModel(c);
            c.setModel(m);
            server.Start();
            Console.ReadKey();
        }
    }
}
