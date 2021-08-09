using System;

namespace _4._2闹钟
{
    public delegate void ClockHandler(TimeEventArgs t1, TimeEventArgs t2);
    public class TimeEventArgs//时间
    { 
        public int hour { get; set; }
        public int min { get; set; }
        public int sec { get; set; }
    }
    public class AlarmClock
    {
        public event ClockHandler OnTick;//嘀嗒事件
        public event ClockHandler OnAlarm;//响铃事件

        public TimeEventArgs CurrentTime, AlarmTime;
        public TimeEventArgs CurrentTime//设置并输出当前时间
        {

        }
        /*public void SetAlarm(int h, int m, int s)//设置响铃时间
        {
            if (h < 25 && h >= 0 && m < 60 && m >= 0 && s < 60 && s >= 0)
            {
                //Console.WriteLine(h + ":" + m + ":" + s);
                AlarmTime = new TimeEventArgs() { hour = h, min = m, sec = s };
            }
            else
            {
                Console.WriteLine("error");
                AlarmTime = new TimeEventArgs() { hour = 0, min = 0, sec = 0 };
            }
        }*/
        public void Time()//当前时间变化，比对设置的闹钟时间
        {
            bool work = true;
            while (work)//循环计时
            {
                if (CurrentTime.sec < 59) CurrentTime.sec++;
                else { CurrentTime.sec = 0; CurrentTime.min++; }

                if (CurrentTime.min > 59) { CurrentTime.min = 0; CurrentTime.hour++; }

                if (CurrentTime.hour > 23) CurrentTime.hour = 0;

                if (CurrentTime.hour == AlarmTime.hour&& 
                    CurrentTime.min == AlarmTime.min&&
                    CurrentTime.sec == AlarmTime.sec)//到达时间，响铃 
                { 
                    OnAlarm(CurrentTime, AlarmTime);
                    work = false;
                }
                else OnTick(CurrentTime, AlarmTime);
            }
        }
    }
    public class Clock
    {
        public AlarmClock alarmclock = new AlarmClock();
        public Clock()
        {
            alarmclock.OnAlarm += new ClockHandler(Alarm);
            alarmclock.OnTick += new ClockHandler(Tick);
        }
        public void Alarm(TimeEventArgs t1, TimeEventArgs t2)
        {
            Console.WriteLine("响铃" + t1.hour + ":" + t1.min + ":" + t1.sec);
        }
        public void Tick(TimeEventArgs t1, TimeEventArgs t2)
        {
            Console.WriteLine("闹钟当前时间" + t1.hour + ":" + t1.min + ":" + t1.sec);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Clock myclock = new Clock();
            myclock.alarmclock.CurrentTime= myclock.alarmclock.SetTime(23, 58, 50);
            myclock.alarmclock.CurrentTime = myclock.alarmclock.SetTime(23, 58, 50);
            myclock.alarmclock.Time();
        }
    }
}
