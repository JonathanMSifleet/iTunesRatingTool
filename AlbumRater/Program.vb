Imports System
Imports System.IO

Module Program
    Sub Main(args As String())

        Dim three, four, five As Decimal
        Dim album, artist As String
        Dim year, score, tracks As Integer
        Const filename As String = "C:\Users\jonathans\Desktop\Ratings.txt"
        Dim CurrentFileWriter As StreamWriter

        While True

            Console.WriteLine("Please enter album name")
            album = Console.ReadLine
            Console.WriteLine("Please enter artist name")
            artist = Console.ReadLine
            Console.WriteLine("Please enter the year the album was released")
            year = Console.ReadLine
            Console.WriteLine("Please enter the number of tracks")
            tracks = Console.ReadLine

            Console.WriteLine("Please enter the number of 3 star songs")
            three = Console.ReadLine
            Console.WriteLine("Please enter the number of 4 star songs")
            four = Console.ReadLine
            Console.WriteLine("Please enter the number of 5 star songs")
            five = Console.ReadLine

            five = (1 / tracks) * five
            four = (1 / tracks) * (four * 0.55)
            three = (1 / tracks) * (three * 0.35)

            score = 100 * (five + four + three)

            CurrentFileWriter = New StreamWriter(filename, FileMode.Append)

            CurrentFileWriter.WriteLine("Album: " & album & ", Artist: " & artist & ", Year: " & year & ", Score: " & score)

            CurrentFileWriter.Close()

            Console.WriteLine(score)
            Console.ReadLine()
            Console.Clear()
        End While

    End Sub
End Module
