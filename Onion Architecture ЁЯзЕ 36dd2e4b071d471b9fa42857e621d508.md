# Onion Architecture 🧅

Hemos optado por la Arquitectura Onion, presentada por Jeffrey Palermo, debido a su sólido historial de éxito en proyectos de software. Esta elección se basa en los siguientes motivos clave:

1. **Principio de Inversión de Dependencias:** La Arquitectura Onion se adhiere al Principio de Inversión de Dependencias, promoviendo la independencia entre capas y la flexibilidad del sistema.
2. **Modularidad y Separación de Responsabilidades:** Nos permite mantener una estructura modular y una clara separación de responsabilidades, esenciales para el desarrollo y mantenimiento eficaz.
3. **Testabilidad:** Facilita pruebas efectivas, garantizando la calidad y confiabilidad del código en nuestro proyecto.
4. **Flexibilidad y Adaptabilidad:** Nos permite adaptarnos a cambios futuros y nuevas tecnologías sin afectar significativamente la funcionalidad existente.
5. **Colaboración Efectiva:** la Arquitectura Onion establece contratos claros entre capas y componentes, lo que facilita la colaboración

![onion_architecture.jpg](Onion%20Architecture%20%F0%9F%A7%85%2036dd2e4b071d471b9fa42857e621d508/onion_architecture.jpg)

# Capas Externas (Outer Layers)

**Infrastructure:** En esta capa reside nuestra base de datos, sistema de archivos o cualquier servicio web externo del que dependamos.

**Tests:** En esta capa residen pruebas unitarias, de integración y de extremo a extremo esenciales para garantizar la calidad y la confiabilidad del código.

**User Interface:** Es la capa más cercana a la interfaz de usuario y proporciona una forma de comunicarse con el núcleo de la aplicación. Esta capa interactúa con la primera capa del **"application core"(application services layer).**

# Núcleo de la Aplicación (Application Core)

**Application Services (Transport Layer**)**:** Dentro de esta capa, definimos lo que nuestro servicio puede hacer a través de una serie de contratos.

**Domain Services:** En esta capa es donde reside la mayor parte de nuestra lógica de negocios. Lleva a cabo las operaciones para convertir A en B, entrada en salida. Específicamente en nuestro proyecto, esta capa se encargará de aspectos como la gestión de emparejamientos, el control de estadísticas, el manejo de algunas reglas del torneo, la gestión de resultados, el control de decks, entre otros.

**Domain Model:** Es la capa de representación de los objetos de datos de alto nivel que utilizamos. Aquí se definen y encapsulan los conceptos fundamentales y los elementos clave del juego, lo que permite una representación fiel y coherente de los datos en la aplicación. Algunos de los aspectos esenciales que se manejan en esta capa incluyen la representación de entidades o conceptos fundamentales de la lógica del proyecto, como jugadores, decks, mazos, partidas y torneos.