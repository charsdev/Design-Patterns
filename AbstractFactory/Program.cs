using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceConstruction spaceconstruction;

            spaceconstruction = new SpaceConstruction(new SpaceContructionFloorFactory());
            spaceconstruction.MakeSpaceContruction();

            spaceconstruction = new SpaceConstruction(new SpaceContructionRoofFactory());
            spaceconstruction.MakeSpaceContruction();

            spaceconstruction = new SpaceConstruction(new SpaceContructionWallFactory());
            spaceconstruction.MakeSpaceContruction();

            Console.ReadKey();
        }
    }

    public class SpaceContructionRoofFactory : SpaceConstructionFactory
    {
        public override IPartShop BuildPartShop()
        {
            System.Console.WriteLine("New Space roof");
            return new Roof();
        }
        public override IWorkers AssignWorkers()
        {
            System.Console.WriteLine("assigned workers to space roof\n");
            return new WorkersRoof();
        }
    }

    public class SpaceContructionFloorFactory : SpaceConstructionFactory
    {
        public override IPartShop BuildPartShop()
        {
            System.Console.WriteLine("New Space floor");
            return new Floor();
        }
        public override IWorkers AssignWorkers()
        {
            System.Console.WriteLine("assigned workers to space floor\n");
            return new WorkersFloor();
        }
    }

    public class SpaceContructionWallFactory : SpaceConstructionFactory
    {
        public override IPartShop BuildPartShop()
        {
            System.Console.WriteLine("New Space wall");
            return new Wall();
        }
        public override IWorkers AssignWorkers()
        {
            System.Console.WriteLine("assigned workers to space wall\n");
            return new WorkersWall();
        }
    }

    class SpaceConstruction
    {
        private SpaceConstructionFactory spaceconstruction;

        public SpaceConstruction(SpaceConstructionFactory spaceconstruction)
        {
            this.spaceconstruction = spaceconstruction;
        }

        public void MakeSpaceContruction()
        {
            var partshop = this.spaceconstruction.BuildPartShop();
            var workers = this.spaceconstruction.AssignWorkers();
        }
    }

}

