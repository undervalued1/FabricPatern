using FabricPatern;

var simpleFactory = new TransportFactory();
Transport car = simpleFactory.CreateTransport("car");
car.Move();

Logistics roadLogistics = new RoadLogistics();
roadLogistics.PlanDelivery(); //Машина едет

Logistics bikeLogistics = new BikeLogistics();
bikeLogistics.PlanDelivery(); // Мотоцикл едет