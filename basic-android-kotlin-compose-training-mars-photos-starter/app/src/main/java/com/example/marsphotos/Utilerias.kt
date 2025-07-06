package com.example.marsphotos

import android.content.Context
import android.content.Intent
import android.graphics.Bitmap
import android.net.Uri
import androidx.core.content.FileProvider
import java.io.File
import java.io.FileOutputStream
import java.io.IOException

// Función de utilidad para compartir el Bitmap
fun shareBitmap(context: Context, bitmap: Bitmap, fileName: String = "qr_code.png") {
    // 1. Guardar el Bitmap en un archivo temporal
    val cachePath = File(context.cacheDir, "images") // Asegúrate de que "images" coincide con file_paths.xml
    cachePath.mkdirs() // Crea el directorio si no existe

    val file = File(cachePath, fileName)
    try {
        val stream = FileOutputStream(file)
        bitmap.compress(Bitmap.CompressFormat.PNG, 90, stream) // Comprime el bitmap a PNG
        stream.close()
    } catch (e: IOException) {
        e.printStackTrace()
        // Manejar el error, ej. mostrar un Toast
        return
    }

    // 2. Obtener la Uri del archivo usando FileProvider
    val uri: Uri = FileProvider.getUriForFile(
        context,
        "${context.packageName}.fileprovider", // Debe coincidir con la 'authorities' en AndroidManifest.xml
        file
    )

    // 3. Crear el Intent de compartir
    val shareIntent: Intent = Intent().apply {
        action = Intent.ACTION_SEND
        putExtra(Intent.EXTRA_STREAM, uri) // Pasa la Uri de la imagen
        type = "image/png" // Define el tipo de contenido
        addFlags(Intent.FLAG_GRANT_READ_URI_PERMISSION) // Otorga permisos de lectura temporal a la app receptora
    }

    // 4. Lanzar el selector de aplicaciones
    context.startActivity(Intent.createChooser(shareIntent, "Compartir QR vía"))
}