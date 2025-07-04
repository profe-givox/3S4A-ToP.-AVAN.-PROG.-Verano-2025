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

@file:OptIn(ExperimentalMaterial3Api::class)

package com.example.marsphotos.ui

import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.Button
import androidx.compose.material3.CenterAlignedTopAppBar
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.material3.TopAppBarDefaults
import androidx.compose.material3.TopAppBarScrollBehavior
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.input.nestedscroll.nestedScroll
import androidx.compose.ui.res.stringResource
import androidx.compose.ui.unit.dp
import androidx.lifecycle.viewmodel.compose.viewModel
import com.example.marsphotos.R
import com.example.marsphotos.ui.screens.HomeScreen
import com.example.marsphotos.ui.screens.MarsViewModel
import com.example.marsphotos.ui.screens.QrCodeDisplay

@Composable
fun MarsPhotosApp() {
    val scrollBehavior = TopAppBarDefaults.enterAlwaysScrollBehavior()
    Scaffold(
        modifier = Modifier.nestedScroll(scrollBehavior.nestedScrollConnection),
        topBar = { MarsTopAppBar(scrollBehavior = scrollBehavior) }
    ) {
        Surface(
            modifier = Modifier
                .fillMaxSize()
                .padding(it)
        ) {
            val marsViewModel: MarsViewModel = viewModel()
            Column {
                HomeScreen(
                    marsUiState = marsViewModel.marsUiState)

                // Estado para almacenar el contenido actual del QR
                var currentQrContent by remember { mutableStateOf("") }

                Column(
                    modifier = Modifier
                        .fillMaxSize()
                        .padding(16.dp),
                    horizontalAlignment = Alignment.CenterHorizontally,
                    verticalArrangement = Arrangement.Center
                ) {
                    Text(text = "Generador de QR para Invitados")
                    Spacer(modifier = Modifier.height(32.dp))

                    // Botón para generar un nuevo QR
                    Button(onClick = {
                            // Aquí generarías el token y la URL real
                            val invitadoId = "INV-${(1000..9999).random()}" // Ejemplo de ID de invitado
                            val fechaExpiracion = System.currentTimeMillis() + (24 * 60 * 60 * 1000) // Válido por 24 horas
                            val token = marsViewModel.generarTokenConDatos(invitadoId, fechaExpiracion)
                            currentQrContent = marsViewModel.crearEnlaceQR(token)
                    }) {
                        Text("Generar QR para Invitado")
                    }

                    Spacer(modifier = Modifier.height(32.dp))

                    // Muestra el QR solo si hay contenido
                    if (currentQrContent.isNotEmpty()) {
                        QrCodeDisplay( viewModel = marsViewModel , qrContent = currentQrContent, qrSize = 250)
                        Spacer(modifier = Modifier.height(16.dp))
                        Text(text = "Contenido del QR: $currentQrContent", style = MaterialTheme.typography.bodySmall)
                    } else {
                        Text("Presiona el botón para generar un QR.")
                    }
                }
            }

        }
    }
}

@Composable
fun MarsTopAppBar(scrollBehavior: TopAppBarScrollBehavior, modifier: Modifier = Modifier) {
    CenterAlignedTopAppBar(
        scrollBehavior = scrollBehavior,
        title = {
            Text(
                text = stringResource(R.string.app_name),
                style = MaterialTheme.typography.headlineSmall,
            )
        },
        modifier = modifier
    )
}
