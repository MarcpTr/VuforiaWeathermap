# Weather AR App

Esta aplicación es una experiencia de realidad aumentada (AR) creada con Unity y Vuforia, que permite a los usuarios ver el tiempo de cada comunidad autónoma de España al mostrar un mapa del país. Utiliza la API de OpenWeather para obtener los datos meteorológicos en tiempo real.

## Características

- **Realidad Aumentada**: Utiliza Vuforia para mostrar el mapa interactivo de España en AR.
- **Pronóstico del Tiempo**: Al escanear el mapa de España, la aplicación muestra el pronóstico del tiempo para cada comunidad autónoma utilizando los datos de la API de OpenWeather.

## Requisitos

- **Unity**: Se requiere Unity 6 o superior.
- **Vuforia**: La app utiliza el SDK de Vuforia para la funcionalidad de AR.
- **Android**: La aplicación está diseñada para dispositivos Android (requiere Android 7.0 o superior).
- **API de OpenWeather**: Necesitarás una clave de API de OpenWeather para acceder a los datos meteorológicos.

## Configuración de la API de OpenWeather

1. Regístrate en [OpenWeather](https://openweathermap.org/) y obtiene una clave de API.
2. En el script que maneja la obtención de datos del tiempo (por ejemplo, `OpenWeather.cs`), reemplaza la clave de API con tu propia clave.
3. 
### Endpoint utilizado:
- **Pronóstico por coordenadas**: `https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&units=metric&lang=sp&appid={API_KEY}`
