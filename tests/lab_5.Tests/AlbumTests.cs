namespace lab_5.Tests;

[TestFixture]
public class AlbumTests
{

    private Album _album;
    
    [SetUp]
    public void Setup()
    {
        _album = new Album();
        
        //Arrange
        _album.AddTrack(new MetalMusic("TestTrack 1", 3.0));
        _album.AddTrack(new PopMusic("TestTrack 2", 2.0));
    }

    [Test]
    public void GetTotalDuration_ReturnsCorrectSum()
    {
        //Act
        double total = _album.GetTotalDuraton();
        
        //Assert
        Assert.That(total, Is.EqualTo(5.0));
    }

    [Test]
    public void FindByDuration_ReturnCorrectTracks()
    {
        //Act
        var result = _album.FindByDuration(1.0, 2.5);
        
        //Assert
        Assert.That(result.Count, Is.EqualTo(1));
        Assert.That(result.First().Title, Is.EqualTo("TestTrack 2"));
    }

    [Test]
    public void AddTrack_NegativeDuration_ThrowsArgumentExeption()
    {
        //Assert and Act
        var ex = Assert.Throws<ArgumentException>(() => new RockMusic("Error", -5.0));
        Assert.That(ex.Message, Does.Contain("Track duration can't be <= 0"));
    }

    [Test]
    public void SortByStyle_TracksAreSortedCorrecly()
    {
        //Act
        _album.SortByStyle();
        var result = _album.GetTracks();
        
        //Assert
        Assert.Multiple(() =>
        {
            Assert.That(result[0].Genre, Is.EqualTo("Metal"));
            Assert.That(result[1].Genre, Is.EqualTo("Pop"));
        });
    }
}