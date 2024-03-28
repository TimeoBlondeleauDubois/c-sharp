using cesiAnimal.animal;

namespace cesiAnimal.vehicle
{
    public interface Drivable
    {
        void mount(Animal animal);
        void move();
        void unmount(Animal animal);
    }
}