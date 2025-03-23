using tpmod6_103022300158;

SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - HafizryandinHM");

video.printVideoDetails();

video.IncreasePlayCount(5000);
video.printVideoDetails();

video.IncreasePlayCount(10000000);
video.printVideoDetails();

for (int i = 0; i < 5; i++)
{
    video.IncreasePlayCount(int.MaxValue);
}