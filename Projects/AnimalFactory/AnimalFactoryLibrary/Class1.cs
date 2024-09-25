namespace AnimalFactoryLibrary
{
    public interface IAnimal
    {
        string Speak();
    }
    public interface IAnimalFactory
    {
        IAnimal CreateMammal();
        IAnimal CreateBird();
        IAnimal CreateReptile();
    }

    public class DesertAnimalFactory : IAnimalFactory
    {
        public IAnimal CreateMammal()
        {
            return new Camel();
        }

        public IAnimal CreateBird()
        {
            return new Falcon();
        }

        public IAnimal CreateReptile()
        {
            return new Lizard();
        }
    }

    public class JungleAnimalFactory : IAnimalFactory
    {
        public IAnimal CreateMammal()
        {
            return new Tiger();
        }

        public IAnimal CreateBird()
        {
            return new Parrot();
        }

        public IAnimal CreateReptile()
        {
            return new Python();
        }
    }

    public class SavannaAnimalFactory : IAnimalFactory
    {
        public IAnimal CreateMammal()
        {
            return new Zebra();
        }

        public IAnimal CreateBird()
        {
            return new Flamingo();
        }

        public IAnimal CreateReptile()
        {
            return new Gecko();
        }
    }

    /// <summary>
    /// 
    /// </summary>

    public class Camel : IAnimal
    {
        public string Speak()
        {
            return "Верблюд: Хрюк!";
        }
    }
    public class Falcon : IAnimal
    {
        public string Speak()
        {
            return "Сокіл: Вереск!";
        }
    }
    public class Flamingo : IAnimal
    {
        public string Speak()
        {
            return "Фламінго: пронизливий крик!";
        }
    }
    public class Gecko : IAnimal
    {
        public string Speak()
        {
            return "Гекон: клац-клац!";
        }
    }
    public class Lizard : IAnimal
    {
        public string Speak()
        {
            return "Ящірка: Скррр!";
        }
    }
    public class Parrot : IAnimal
    {
        public string Speak()
        {
            return "Папуга: Привіт!";
        }
    }
    public class Python : IAnimal
    {
        public string Speak()
        {
            return "Пітон: Шипить!";
        }
    }
    public class Tiger : IAnimal
    {
        public string Speak()
        {
            return "Тигр: Гррр!";
        }
    }
    public class Zebra : IAnimal
    {
        public string Speak()
        {
            return "Зебра: *еще какой-то звук*";
        }
    }
}
