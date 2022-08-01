namespace Factory
{
    public abstract class SpaceConstructionFactory
    {
        public abstract IPartShop BuildPartShop();
        public abstract IWorkers AssignWorkers();
    }

}

