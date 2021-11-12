using System;
using System.Collections.Generic;

namespace ConsoleApp3_inheritance
{
    public class ClassRoom
    {
        List<Pupil> Pupils;

        public ClassRoom(params Pupil[] pupils)
        {
            Pupils = new List<Pupil>();
            for (int i = 0; i < pupils.Length; i++)
            {
                Pupils.Add(pupils[i]);
            }
        }

        public void PrintStatistics()
        {
            for (int i = 0; i < Pupils.Count; i++)
            {
                Console.WriteLine($"Name: {Pupils[i].name}");
                Console.WriteLine($"Study: {Pupils[i].Study()}, Read: {Pupils[i].Read()}, Write: {Pupils[i].Write()}, Relax: {Pupils[i].Relax()}");
            }
        }
    }
}