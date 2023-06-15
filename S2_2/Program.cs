using S2_2.Components;

BikeFrame bike1 = new SpecializedBikeFrame();
BikeFrame bike2 = new GTBikeFrame();

// - Ok, i built a modular design by following IoC, but i still can't change my handlebar on any bike :((
// - Yes, you added abstractions between components, but... your components are still responsible for obtaining their dependencies