﻿using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager:IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Oyuncu başarıyla eklendi");
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu bilgileri güncellendi");
        }
    }
}
