# Semana 4 - Tarea 1: Eventos en Windows Forms

Formulario en C# (Windows Forms) que usa eventos con Label, TextBox, Panel, Button y Timer.

## Controles y eventos

| Control | Evento | Qué hace |
|---|---|---|
| Label (`lblEstado`) | `Click` | Cuenta los clics, cambia el texto y alterna el color |
| TextBox (`txtDigitos`) | `KeyPress` | Solo permite dígitos |
| Panel (`pnlImagenes`) | `DragEnter`, `DragDrop` | Recibe una imagen arrastrada y la muestra |
| Button (`btnTimer`) | `Click` | Inicia o detiene el Timer |
| Timer (`timer`) | `Tick` | Suma un segundo y lo muestra en pantalla |

## Uso de `+=`

El operador `+=` **suscribe** un método a un evento: cuando el evento ocurre, se ejecuta ese método.

El Designer lo genera automáticamente en `Form1.Designer.cs`:

```csharp
lblEstado.Click += lblEstado_Click;
txtDigitos.KeyPress += txtDigitos_KeyPress;
pnlImagenes.DragEnter += pnlImagenes_DragEnter;
pnlImagenes.DragDrop += pnlImagenes_DragDrop;
btnTimer.Click += btnTimer_Click;
timer.Tick += timer_Tick;
```

Un evento puede tener varios métodos suscritos. Con `-=` se quita la suscripción.

## Uso de lambdas

Una lambda es un método corto y sin nombre, escrito en el mismo lugar donde se suscribe. Se usa con `+=` cuando la acción es pequeña:

```csharp
lblEstado.MouseEnter += (s, e) => lblEstado.Cursor = Cursors.Hand;
```

- `s` es el objeto que lanzó el evento (`sender`).
- `e` son los datos del evento (`EventArgs`).
- `=>` separa los parámetros del cuerpo.

**Diferencia:** el método con nombre (`lblEstado_Click`) se puede reutilizar y es mejor para lógica larga. La lambda es más corta, pero no se puede quitar con `-=` fácilmente.

## Pruebas realizadas

| Prueba | Resultado |
|---|---|
| Clic en el Label | Muestra "Clic número N" y alterna azul/verde |
| Escribir `12a3b4` en el TextBox | Queda `1234` |
| Arrastrar una imagen al Panel | Se muestra la imagen |
| Arrastrar un `.txt` al Panel | Mensaje "Solo se aceptan imágenes." |
| Botón "Iniciar Timer" | Contador sube cada segundo |
| Botón "Detener Timer" | El contador se detiene y continúa al reanudar |

## Capturas

(Agrega aquí tus capturas de pantalla)

## Cómo ejecutar

1. Abrir `Semana4Tarea1.sln` en Visual Studio.
2. Pulsar **F5**.
