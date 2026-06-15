# Informe del Proyecto Multimedia (Gestión 1/2026)

Este documento describe la estructura y el contenido del proyecto de la materia de Multimedia de la Universidad Mayor de San Andrés (UMSA), gestión 1/2026. El proyecto está dividido en tres áreas principales que abarcan desde el procesamiento algorítmico de imágenes hasta la producción de contenido interactivo 3D.

## Estructura del Proyecto

El directorio principal del proyecto se divide en las siguientes tres carpetas fundamentales:

### 1. 01_Procesamiento_Imagenes
Esta sección contiene una aplicación de escritorio desarrollada en **C#** (Windows Forms Application). La aplicación actúa como un compendio de ejercicios prácticos de procesamiento digital de imágenes. 

**Requisito de Base de Datos:** Se requiere tener una base de datos local **SQL Server** (instancia `.\SQLEXPRESS`) llamada `texturas`. Algunos formularios (como el Form3 y Form4) utilizan esta base de datos mediante Autenticación de Windows (`Integrated Security=True`) para guardar o leer información.

Características principales:
*   **Interfaz Principal (Form1):** Funciona como un menú que da acceso a los distintos ejercicios.
*   **Filtros Básicos (Form2):** Permite cargar una imagen y aplicarle filtros de extracción de canales RGB (Rojo, Verde, Azul), conversión a escala de grises y efecto negativo.
*   **Clasificación de Texturas (Form5):** Implementa un algoritmo de clasificación de píxeles basado en la "Distancia Mínima". Utiliza centroides de color para identificar y segmentar texturas en la imagen como: césped, tierra, cemento y agua, permitiendo ajustar un umbral de tolerancia.
*   **Otros Ejercicios:** Cuenta con otros formularios (Form3, Form4, Form6) que contienen más algoritmos y filtros avanzados desarrollados durante el curso.

### 2. 02_Produccion_Multimedia
Esta carpeta agrupa todo el trabajo de producción audiovisual e interactiva, centrado en un proyecto lúdico y 3D ("La Vaca Lola"). Se divide en:

*   **Cover_Vaca_Lola (Recursos / Assets):** Almacena los elementos multimedia en bruto utilizados para la producción. Incluye:
    *   **Texturas e Imágenes:** `Brick_Wall_028_height.png`, `material_1900.png`, `terra 06.jpg`, y referencias fotográficas como `illimani.jpg`.
    *   **Modelos 3D:** Recursos y modelos, incluyendo material extra (como recursos de The Simpsons Hit & Run).
    *   **Audio:** Efectos de sonido o pistas musicales para la aplicación.

*   **vaca_lola_webgl (Aplicación Interactiva):** Contiene el producto final compilado. Es una aplicación interactiva o minijuego desarrollado en el motor **Unity** y exportado a WebGL. Puede ejecutarse directamente abriendo el archivo `index.html` en cualquier navegador web moderno, sin necesidad de instalaciones adicionales.

### 3. 03_Documentacion_Individual
Esta carpeta está destinada a albergar el respaldo teórico y académico del proyecto.
*   **Informe Técnico:** Contiene el archivo `informe_tecnico_individual.docx`, el cual es el documento formal con los detalles técnicos, marco teórico, justificaciones de diseño y conclusiones individuales del trabajo realizado.

---
*Nota: Este archivo markdown fue generado para proporcionar una visión general rápida de todos los componentes que integran el repositorio del proyecto multimedia.*
