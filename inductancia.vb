Module module
    Sub main()
        Dim frecuencia As Double
        Dim inductancia As Double
        Dim impedancia As Double


        console.write("ingrese la frecuencia (Hz): ")
        frecuencia = console.readline()
        console.write("ingrese el valor de la inducatancia (h)")
        inductancia = console.readline()
        impedancia = 2 * XL pi + frecuencia + inductancia
        console.writeline("la impedancia indictiva es:" & impedancia)

    End Sub
End Module