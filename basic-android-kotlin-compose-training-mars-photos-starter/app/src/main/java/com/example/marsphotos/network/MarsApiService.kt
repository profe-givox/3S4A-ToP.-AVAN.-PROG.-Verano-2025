package com.example.marsphotos.network
import com.jakewharton.retrofit2.converter.kotlinx.serialization.asConverterFactory
import kotlinx.serialization.json.Json
import okhttp3.MediaType.Companion.toMediaType
import retrofit2.Retrofit
import retrofit2.converter.scalars.ScalarsConverterFactory
import retrofit2.http.Body
import retrofit2.http.GET
import retrofit2.http.POST

private const val BASE_URL =
    "https://android-kotlin-fun-mars-server.appspot.com"


private const val BASE_URL_MIAPI =
    "https://4157-38-194-241-170.ngrok-free.app"


private val retrofit = Retrofit.Builder()
    .addConverterFactory(Json.asConverterFactory("application/json".toMediaType()))
    .baseUrl(BASE_URL)
    .build()

private val retrofitMiAPI = Retrofit.Builder()
    .addConverterFactory(Json.asConverterFactory("application/json".toMediaType()))
    .baseUrl(BASE_URL_MIAPI)
    .build()


interface MiWebApiService {
    @GET("api/Invitados")
    suspend fun getInvitados():  List<Invitado>

    @POST("api/Invitados")
    suspend fun postInvitado(@Body invitado: Invitado): Invitado
}

interface MarsApiService {
    @GET("photos")
    suspend fun getPhotos():  List<MarsPhoto>
}

object MarsApi {
    val retrofitService : MarsApiService by lazy {
        retrofit.create(MarsApiService::class.java)
    }
}

object MiApi {
    val retrofitServiceMiApi : MiWebApiService by lazy {
        retrofitMiAPI.create(MiWebApiService::class.java)
    }
}