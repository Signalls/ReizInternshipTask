namespace ReizTechTask
{
    public class LesserAngle
    {
        public static double calculateLesserAngle(int hour, int minute)

        {
            double angle = 0;
            // Calculate the angle made by the hour hand
            double hourAngle = (hour % 12 + minute / 60.0) * 30;

            // Calculate the angle made by the minute hand
            double minuteAngle = minute * 6;

            // Calculate the difference between the angles
            angle = Math.Abs(hourAngle - minuteAngle);

            // Take the lesser angle between the two possible angles
            if (angle > 180)
            {
                angle = 360 - angle;
            }

            return angle;
        }


    }
}
