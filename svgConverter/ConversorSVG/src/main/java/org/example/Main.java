package org.example;

import java.io.FileWriter;
import java.io.IOException;

public class Main {
    public static void main(String[] args) {
        // Contenido del archivo SVG
        String contenidoSVG = "<svg width=\"378\" height=\"397\" viewBox=\"0 0 378 397\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\n" +
                "<g clip-path=\"url(#clip0_117_2055)\">\n" +
                "<path d=\"M16.2083 347.375H361.792L189 33.0833L16.2083 347.375ZM204.708 297.75H173.292V264.667H204.708V297.75ZM204.708 231.583H173.292V165.417H204.708V231.583Z\" fill=\"white\"/>\n" +
                "</g>\n" +
                "<defs>\n" +
                "<clipPath id=\"clip0_117_2055\">\n" +
                "<rect width=\"377\" height=\"397\" fill=\"white\" transform=\"translate(0.5)\"/>\n" +
                "</clipPath>\n" +
                "</defs>\n" +
                "</svg>\n";

        // Ruta del archivo SVG
        String rutaArchivo = "C:\\Users\\Aitor\\Desktop\\incidencia.svg";

        // Crear el archivo SVG y escribir el contenido
        try (FileWriter writer = new FileWriter(rutaArchivo)) {
            writer.write(contenidoSVG);
            System.out.println("Archivo SVG creado exitosamente.");
        } catch (IOException e) {
            System.err.println("Error al escribir el archivo SVG: " + e.getMessage());
        }
    }
}