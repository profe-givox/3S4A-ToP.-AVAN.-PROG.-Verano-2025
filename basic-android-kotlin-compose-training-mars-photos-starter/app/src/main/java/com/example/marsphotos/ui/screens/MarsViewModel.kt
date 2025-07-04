/*
 * Copyright (C) 2023 The Android Open Source Project
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
package com.example.marsphotos.ui.screens

import android.graphics.Bitmap
import android.graphics.Color
import android.util.Log
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.setValue
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.marsphotos.network.MarsApi
import com.example.marsphotos.network.MiApi
import com.google.zxing.BarcodeFormat
import com.google.zxing.qrcode.QRCodeWriter
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import kotlinx.coroutines.withContext
import java.io.IOException
import java.util.UUID

sealed interface MarsUiState {
    data class Success(val photos: String) : MarsUiState
    object Error : MarsUiState
    object Loading : MarsUiState
}

class MarsViewModel : ViewModel() {
    /** The mutable State that stores the status of the most recent request */
    var marsUiState: MarsUiState by mutableStateOf(MarsUiState.Loading)
        private set

    /**
     * Call getMarsPhotos() on init so we can display status immediately.
     */
    init {
        //getMarsPhotos()
        getInvitados()
    }

    /**
     * Gets Mars photos information from the Mars API Retrofit service and updates the
     * [MarsPhoto] [List] [MutableList].
     */
    fun getInvitados() {
        //marsUiState = "Set the Mars API status response here!"
        viewModelScope.launch {

            marsUiState = try {
                //val listResult = MarsApi.retrofitService.getPhotos()
                val listResult = MiApi.retrofitServiceMiApi.getInvitados()
                listResult.forEach {
                    //Log.d("id: ${it.id}", "${it.imgSrc}")
                    Log.d("id: ${it.id}", "${it.nombre}")
                }
                //MarsUiState.Success("Success: ${listResult.size} Mars photos retrieved")
                MarsUiState.Success("Success: ${listResult.size} Invitados retrieved")
            } catch (e: IOException) {
                Log.d("Error en invocacion de API", "${e.message}")
                MarsUiState.Error
            }

        }

        /**
         * Gets Mars photos information from the Mars API Retrofit service and updates the
         * [MarsPhoto] [List] [MutableList].
         */
        fun getMarsPhotos() {
            //marsUiState = "Set the Mars API status response here!"
            viewModelScope.launch {

                marsUiState = try {
                    val listResult = MarsApi.retrofitService.getPhotos()
                    listResult.forEach {
                        Log.d("id: ${it.id}", "${it.imgSrc}")
                    }
                    MarsUiState.Success("Success: ${listResult.size} Mars photos retrieved")
                } catch (e: IOException) {
                    MarsUiState.Error
                }

            }

        }
    }

    /**
     * Genera un token único utilizando un UUID.
     * En un escenario de producción, este token debería ser más robusto (ej. JWT)
     * y contener información cifrada o firmada para mayor seguridad y validez.
     */
    fun generarTokenUnico(): String {
        return UUID.randomUUID().toString()
    }

    /**
     * Genera un token más complejo que podría incluir un ID de invitado y una fecha de expiración.
     * Idealmente, esta cadena debería ser cifrada o firmada para seguridad.
     */
    fun generarTokenConDatos(invitadoId: String, fechaExpiracionMillis: Long): String {
        // Para un proyecto de fin de curso, una concatenación simple puede ser suficiente,
        // pero sé consciente de las limitaciones de seguridad.
        // Formato: "INV-ID_FECHAEXP_UUID"
        return "INV-${invitadoId}_${fechaExpiracionMillis}_${UUID.randomUUID()}"
    }

    // Define la URL base de tu API REST.
    // Para pruebas en emulador/dispositivo, usa la IP de tu máquina host.
    // Asegúrate de que tu firewall permite las conexiones entrantes en ese puerto.
    val BASE_URL_ACCESO = "http://192.168.1.100:5000/api/acceso/validar" // Ejemplo

    /**
     * Construye la URL que se incrustará en el código QR.
     * El token se pasa como un parámetro de consulta.
     */
    fun crearEnlaceQR(token: String): String {
        return "$BASE_URL_ACCESO?token=$token"
    }

    /**
     * Genera un Bitmap de un código QR a partir de una cadena de contenido.
     * Se ejecuta en un hilo de E/S para no bloquear la UI.
     *
     * @param content La cadena de texto a codificar en el QR (ej. la URL con el token).
     * @param size El tamaño deseado (ancho y alto) del Bitmap del QR en píxeles.
     * @return El Bitmap del QR generado, o null si hay un error.
     */
    suspend fun generarQrBitmap(content: String, size: Int): Bitmap? {
        return withContext(Dispatchers.IO) { // Ejecuta esta tarea en un hilo de fondo
            try {
                val writer = QRCodeWriter()
                // Codifica el contenido en una matriz de bits
                val bitMatrix = writer.encode(content, BarcodeFormat.QR_CODE, size, size)
                val bitmap = Bitmap.createBitmap(size, size, Bitmap.Config.RGB_565)

                // Itera sobre la matriz de bits para pintar el Bitmap
                for (x in 0 until size) {
                    for (y in 0 until size) {
                        bitmap.setPixel(x, y, if (bitMatrix[x, y]) Color.BLACK else Color.WHITE)
                    }
                }
                bitmap
            } catch (e: Exception) {
                // Imprime el stack trace para depuración
                e.printStackTrace()
                null
            }
        }
    }
}