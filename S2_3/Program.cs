using S2_3.Components;

BikeFrame bike = new SpecializedBikeFrame(
    new FizikSaddle(),
    new FsaHandlebar(),
    new DTSwissWheel(new ContinentalTyre()),
    new DTSwissWheel(new ContinentalTyre())
);

// exact the same bike but with another handlebar
BikeFrame bikeWithAnotherHandlebar = new SpecializedBikeFrame(
    new FizikSaddle(),
    new TruvativHandlebar(),
    new DTSwissWheel(new ContinentalTyre()),
    new DTSwissWheel(new ContinentalTyre())
);

// - Yeah! finally i assembled my bike with another handlebar :)))
// - Yes, that's because you moved the responsibility of creating and injecting dependencies outside

// - Also i can assemble any combination i want!