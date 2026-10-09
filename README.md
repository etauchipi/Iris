# Iris - Monitoreo de Integración

![Iris Logo](./Resources/LogoPpal.bmp)

## 📌 Descripción

**Iris** es una aplicación de escritorio desarrollada en C# utilizando Windows Forms. Su propósito principal es monitorear e integrarse con el servicio web de Opinat a través de SOAP (WCF) para el envío automatizado de encuestas de satisfacción.

La aplicación se encarga de leer información, estructurarla en formato XML, procesarla mediante un servicio web externo (`wsOpinat.appmoduleswscontrollersApiSoapControllerPortClient`) y mantener un conteo en tiempo real de encuestas:
- Enviadas
- Procesadas
- Ok (Exitosas)
- Rechazadas

## 🚀 Tech Stack

La aplicación ha sido desarrollada y configurada para funcionar con la siguiente pila tecnológica:

- **Lenguaje:** C#
- **Framework:** .NET Framework 4.5.2
- **Interfaz Gráfica:** Windows Forms (WinForms)
- **Comunicación Web:** Windows Communication Foundation (WCF) / SOAP Services
- **Estructura de Datos:** ADO.NET (DataSet, DataRow) y XML

## ⚙️ Instalación y Configuración del Entorno Local

Sigue estos pasos para clonar, configurar y ejecutar el proyecto de forma local.

### 1. Prerrequisitos

- **Visual Studio 2017 o superior** (Se recomienda la carga de trabajo de desarrollo de escritorio de .NET).
- **.NET Framework 4.5.2** instalado en el sistema.

### 2. Clonar el Repositorio

Clona el repositorio en tu máquina local:

```bash
git clone <URL_DEL_REPOSITORIO>
cd <DIRECTORIO_DEL_PROYECTO>
```

### 3. Configuración de Variables (`App.config`)

Antes de compilar y ejecutar, debes configurar correctamente las credenciales del servicio web y otras variables en el archivo `App.config`.

Abre el archivo `App.config` en Visual Studio y ajusta los valores del nodo `<appSettings>`:

```xml
<appSettings>
  <add key="FormatoFecha" value="8" />
  <add key="center_id" value="00000" />
  <add key="prefijo" value="0000-" />
  <!-- Credenciales para el servicio de Opinat -->
  <add key="user_opinat" value="TU_USUARIO_AQUI" />
  <add key="pass_opinat" value="TU_CONTRASEÑA_AQUI" />
  <add key="ClientSettingsProvider.ServiceUri" value="" />
</appSettings>
```

Además, asegúrate de que el endpoint del cliente WCF (`<client><endpoint address="..." />`) en el mismo `App.config` apunte a la URL correcta del entorno (Pruebas o Producción).

### 4. Compilar y Ejecutar

1. Abre el archivo de solución `Iris.sln` con Visual Studio.
2. Restaura los paquetes NuGet (si aplica) y asegúrate de que no haya dependencias faltantes.
3. Compila la solución seleccionando **Build > Build Solution** (`Ctrl + Shift + B`).
4. Presiona **Start** (`F5`) para ejecutar la aplicación en modo Debug.

## 📂 Estructura de Carpetas

A continuación, una breve descripción de la estructura principal del proyecto:

```
/
├── App.config                     # Archivo principal de configuración (credenciales, endpoints WCF).
├── Iris.sln                       # Archivo de la solución de Visual Studio.
├── Iris.csproj                    # Archivo de proyecto de C# con referencias y dependencias.
├── Program.cs                     # Punto de entrada principal de la aplicación.
├── frmMain.cs                     # Lógica y eventos del formulario principal (monitoreo, conteo, conexión SOAP, XML).
├── frmMain.Designer.cs            # Código autogenerado para el diseño de la UI del formulario principal.
├── Connected Services/            # Referencias a servicios WCF (SOAP).
│   └── wsOpinat/                  # Proxies y contratos generados para la comunicación con Opinat.
├── Properties/                    # Propiedades del ensamblado, recursos y configuraciones.
└── Resources/                     # Recursos gráficos e imágenes utilizados en la UI (Logos, botones, etc.).
```

## 📖 Guía de Uso

Una vez iniciada la aplicación, se mostrará el formulario principal `frmMain` con el título **"Monitoreo integración"**.

1. **Monitoreo Automático:**
   Al iniciar (`Form_Load`), la aplicación arranca un temporizador (`timerMain`) configurado cada 15 segundos que sirve de base para el chequeo/envío continuo.
2. **Visualización de Contadores:**
   En la pantalla principal, verás en tiempo real los contadores de encuestas: **Enviadas**, **Procesadas**, **Ok** y **Rechazadas**. Estos se actualizan dinámicamente.
3. **Prueba de Conexión:**
   Puedes utilizar el botón "Prueba" para enviar un mensaje de prueba al servicio web de Opinat (`apiTestWithoutLogin`). La respuesta del servidor se mostrará en las etiquetas inferiores (`lblEncuesta1`).
4. **Procesamiento de Datos:**
   Internamente, el código de `frmMain.cs` contiene métodos como `LlenaXML()` que toma un `DataSet` y lo convierte a una cadena XML segura escapando caracteres especiales para la generación de la encuesta.
