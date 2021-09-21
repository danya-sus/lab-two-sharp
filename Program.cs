using System;
using System.Threading;

namespace Lab2Sharp
{
    //Abstract Class
    abstract class Musician
    {
        //Abstract Class Fields
        public string Name { get; set; }
        public string Specializathion { get; set; }
        public string[] Repertoire { get; set; }
        public int DateOfBirth;
        static readonly protected int date = DateTime.Now.Year;

        //Abstract Class Methods
        protected abstract void LearnNewSong(string new_song);
        public abstract void GetInfo();
        
        protected static int GetAge(Musician musician)
        {
            return date - musician.DateOfBirth;
        }
    }
    
    //Child Class
    class Guitarman : Musician
    {
        //New Field
        protected string Instrument { get; set; }
        
        //New Methods
        protected override void LearnNewSong(string new_song)
        {
            Console.WriteLine($"{this.Name} learning the song {new_song}...");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Learning...");
                Thread.Sleep(500);
            }

            string[] temp = new string[this.Repertoire.Length + 1];
            this.Repertoire.CopyTo(temp, 0);
            temp[temp.Length - 1] = new_song;
            this.Repertoire = temp;
            
            Console.WriteLine("The song is learned!\n\n\n");
        }
        
        //Virtual Method
        public virtual void PlayGuitar()
        {
            Random gen = new Random();
            int rand = gen.Next(maxValue: this.Repertoire.Length);
            Console.WriteLine($"{this.Name} plays the {this.Repertoire[rand]} on {this.Instrument}...");
            for (int i = 0; i < 10; i++)
            {
                rand = gen.Next(2);
                if (rand == 1) Console.WriteLine("Right note! Great!");
                else Console.WriteLine("Wrong note! Badly!");
            }
            Console.WriteLine($"{this.Name} played the song.\n\n\n");
        }

        //Redefined Method
        public override void GetInfo()
        {
            Console.WriteLine("Information about guitarist:");
            Console.WriteLine($"Name: {this.Name};");
            Console.WriteLine($"Specialization: {this.Specializathion};");
            Console.WriteLine($"Instrument: {this.Instrument}");
            Console.Write($"Repertoire: ");
            foreach (string element in this.Repertoire)
            {
                Console.Write($"{element}; ");
            }
            Console.WriteLine($"\nDate of birth: {this.DateOfBirth} ({Guitarman.GetAge(this)} years old).\n\n\n");
        }

        //Constructors
        public Guitarman()
        {
            
        }

        public Guitarman(string name, string instrument, string[] repertoire, int dateOfbirth)
        {
            this.Name = name;
            this.Specializathion = "Guitarist";
            this.Instrument = instrument;
            this.Repertoire = repertoire;
            this.DateOfBirth = dateOfbirth;
        }
    }

    //Infertile Class
    sealed class Solo_Guitarist : Guitarman
    {
        //New Field
        private string[] Skills { get; set; }

        //New Method
        private void GetSkill(string new_skill)
        {
            string[] temp = new string[this.Skills.Length + 1];
            this.Skills.CopyTo(temp, 0);
            temp[temp.Length - 1] = new_skill;
            this.Skills = temp;
            
            Console.WriteLine($"OK, {this.Name} get {new_skill} skill!");
        }
        
        //Redefined Method
        public override void GetInfo()
        {
            Console.WriteLine("Information about solo-guitarist:");
            Console.WriteLine($"Name: {this.Name};");
            Console.WriteLine($"Specialization: {this.Specializathion};");
            Console.WriteLine($"Instrument: {this.Instrument}");
            Console.Write(($"Skills: "));
            foreach (string element in this.Skills)
            {
                Console.Write($"{element}; ");
            }
            Console.Write($"\nRepertoire: ");
            foreach (string element in this.Repertoire)
            {
                Console.Write($"{element}; ");
            }
            Console.WriteLine($"\nDate of birth: {this.DateOfBirth} ({Solo_Guitarist.GetAge(this)} years old).\n\n\n");
        }
        
        //Constrictors
        public Solo_Guitarist()
        {
            
        }

        public Solo_Guitarist(string name, string instrument, string[] skills, string[] repertoire, int dateOfbirth)
        {
            this.Name = name;
            this.Specializathion = "Solo-guitarist";
            this.Instrument = instrument;
            this.Repertoire = repertoire;
            this.Skills = skills;
            this.DateOfBirth = dateOfbirth;
        }
    }

    //Infertile Class
    sealed class Rhythm_Guitarist : Guitarman
    {
        //New Field
        private string StyleOfMusic { get; set; }
        
        //Redefined Method
        public override void GetInfo()
        {
            Console.WriteLine("Information about rhythm-guitarist:");
            Console.WriteLine($"Name: {this.Name};");
            Console.WriteLine($"Specialization: {this.Specializathion};");
            Console.WriteLine($"Instrument: {this.Instrument}");
            Console.WriteLine($"Style of music: {this.StyleOfMusic};");
            Console.Write($"\nRepertoire: ");
            foreach (string element in this.Repertoire)
            {
                Console.Write($"{element}; ");
            }
            Console.WriteLine($"\nDate of birth: {this.DateOfBirth} ({Rhythm_Guitarist.GetAge(this)} years old).\n\n\n");
        }
        
        //Contructors
        public Rhythm_Guitarist()
        {
            
        }

        public Rhythm_Guitarist(string name, string instrument, string style, string[] repertoire, int dateOfbirth)
        {
            this.Name = name;
            this.Specializathion = "Rhythm-guitarist";
            this.Instrument = instrument;
            this.StyleOfMusic = style;
            this.Repertoire = repertoire;
            this.DateOfBirth = dateOfbirth;
        }
    }

    //Infertile Class
    sealed class Singer : Musician
    {
        //New Field
        public string TimbreOfVoice { get; set; }
        
        //New Method
        public void SingSong()
        {
            Random gen = new Random();
            int rand = gen.Next(maxValue: this.Repertoire.Length);
            Console.WriteLine($"{this.Name} sing the song {this.Repertoire[rand]}...");
            for (int i = 0; i < 10; i++)
            {
                rand = gen.Next(3);
                switch (rand)
                {
                    case 0:
                    {
                        Console.WriteLine("Sang higher! Badly!");
                        break;
                    }
                    case 1:
                    {
                        Console.WriteLine("A clean note! Grateful!");
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Sang below! Badly!");
                        break;
                    }
                }
            }
            Console.WriteLine($"{this.Name} sing the song.\n\n\n");
        }
        
        //Redefined Method
        protected override void LearnNewSong(string new_song)
        {
            Console.WriteLine($"{this.Name} learning the song {new_song}...");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Learning...");
                Thread.Sleep(500);
            }

            string[] temp = new string[this.Repertoire.Length + 1];
            this.Repertoire.CopyTo(temp, 0);
            temp[temp.Length - 1] = new_song;
            this.Repertoire = temp;
            
            Console.WriteLine("The song is learned!\n\n\n");
        }

        //Redefined Method
        public override void GetInfo()
        {
            Console.WriteLine("Information about singer:");
            Console.WriteLine($"Name: {this.Name};");
            Console.WriteLine($"Specialization: {this.Specializathion};");
            Console.WriteLine($"Timbre of voice: {this.TimbreOfVoice};");
            Console.Write($"Repertoire: ");
            foreach (string element in this.Repertoire)
            {
                Console.Write($"{element}; ");
            }
            Console.WriteLine($"\nDate of birth: {this.DateOfBirth} ({Singer.GetAge(this)} years old).\n\n\n");
        }
        
        //Constructors
        public Singer()
        {
            
        }

        public Singer(string name,string timbreOfVoice, string[] repertoire, int dateOfbirth)
        {
            this.Name = name;
            this.Specializathion = "Singer";
            this.TimbreOfVoice = timbreOfVoice;
            this.Repertoire = repertoire;
            this.DateOfBirth = dateOfbirth;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] temp_0 = new string[] {"Slide", "Tapping", "Swipe"};
            string[] temp_1 = new string[] {"Back In Black", "Перемен", "Группа крови" };
            Solo_Guitarist One = new Solo_Guitarist("Freddy","Gibson Rock Classic", temp_0, temp_1, 1987);
            
            One.GetInfo();
            
            
            Console.WriteLine("Hello World!");
        }
    }
}