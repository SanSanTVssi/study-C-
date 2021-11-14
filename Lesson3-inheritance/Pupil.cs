namespace ConsoleApp3_inheritance
{
    public class Pupil
    {
        public string name { get; set; }

        public Pupil(string name)
        {
            this.name = name;
        }
        public virtual int Study()
        {
            return 0;
        }

        public virtual int Read()
        {
            return 0;
        }

        public virtual int Write()
        {
            return 0;
        }

        public virtual int Relax()
        {
            return 0;
        } 
    }

    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name): base(name) {}
        public override int Study()
        {
            return 100;
        }

        public override int Read()
        {
            return 75;
        }

        public override int Write()
        {
            return 50;
        }

        public override int Relax()
        {
            return 0;
        } 
    }
    
    class GoodPupil : Pupil
    {
        public GoodPupil(string name): base(name) {}
        public override int Study()
        {
            return 75;
        }

        public override int Read()
        {
            return 75;
        }

        public override int Write()
        {
            return 75;
        }

        public override int Relax()
        {
            return 25;
        } 
    }
    
    class BadPupil : Pupil
    {
        public BadPupil(string name): base(name) {}
        public override int Study()
        {
            return 25;
        }

        public override int Read()
        {
            return 100;
        }

        public override int Write()
        {
            return 100;
        }

        public override int Relax()
        {
            return 100;
        } 
    }
}