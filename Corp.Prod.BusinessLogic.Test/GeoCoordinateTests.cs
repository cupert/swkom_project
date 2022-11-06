namespace Corp.Prod.BusinessLogic.Test
{
    public class GeoCoordinateTests
    {
        [Fact]
        public void Latitude_testFunction_InputIs2Point3_Return2Point3()
        {
            var geoCoordinate = new GeoCoordianteLogic();
            double result = geoCoordinate.testFunction(2.3);

            Assert.Equal(2.3, result);
        }

        [Fact]
        public void Latitude_testFunction_InputIsNaN_Return0Point0()
        {
            var geoCoordinate = new GeoCoordianteLogic();
            double result = geoCoordinate.testFunction(double.NaN);

            Assert.Equal(0.0, result);
        }

        
    }
}