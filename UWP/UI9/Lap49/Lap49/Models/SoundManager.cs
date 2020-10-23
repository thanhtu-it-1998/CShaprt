﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap49.Models
{
    class SoundManager
    {
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allSounds = getSounds();
            allSounds.Clear();
            allSounds.ForEach(p => sounds.Add(p));
        }
        public static void GetSoundByCategory(ObservableCollection<Sound> sounds,SoundCategory soundCategory)
        {
            var allSounds = getSounds();
            var filterSounds = allSounds.Where(p => p.Category == soundCategory).ToList();
            allSounds.Clear();
            allSounds.ForEach(p => sounds.Add(p));
        }
        public static List<Sound> getSounds()
        {
            var sounds = new List<Sound>();

            sounds.Add(new Sound("Cow", SoundCategory.Animals));
            sounds.Add(new Sound("Cat", SoundCategory.Animals));

            sounds.Add(new Sound("Gun", SoundCategory.Cartoons));
            sounds.Add(new Sound("Spring", SoundCategory.Cartoons));

            sounds.Add(new Sound("Clock", SoundCategory.Taunts));
            sounds.Add(new Sound("LOL", SoundCategory.Taunts));

            sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundCategory.Warnings));

            return sounds;
        }
    }
}