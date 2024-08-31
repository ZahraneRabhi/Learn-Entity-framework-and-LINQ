# LEARN-LINQ Repo

This solution is designed to help me learn and practice [Entity FrameWork](https://learn.microsoft.com/en-us/aspnet/entity-framework) and [LINQ](https://learn.microsoft.com/en-us/dotnet/csharp/linq/) (Language-Integrated Query) in C#. It includes a simple API for managing heroes, inspired by characters from 'The Boys' series.
<div align="center">
  <img src="https://th.bing.com/th/id/R.c8eb33e4c72211b1b07b14bfa5119b3a?rik=xz0J%2fNRiO7Hs1A&pid=ImgRaw&r=0" alt="Homelander" width="40%"/>
</div>

## Project Structure

- **Models**: Contains the `Hero` class, which represents a hero with properties like `Id`, `Name`, `Description`, and `Threat`.
- **Controllers**: Contains the `HeroesController` class, which provides endpoints to manage heroes.
- **Seeders**: Contains the `HeroSeeder` class, which seeds the database with a list of hardcoded heroes.

## Endpoints

### Get All Heroes

- **URL**: `/api/heroes`
- **Method**: `GET`
- **Description**: Retrieves a list of all heroes.

### Add a New Hero

- **URL**: `/api/heroes`
- **Method**: `POST`
- **Description**: Adds a new hero to the database.
- **Body**: JSON object representing the hero.

### Delete All Heroes

- **URL**: `/api/heroes/all`
- **Method**: `DELETE`
- **Description**: Deletes all heroes from the database.

### Seed Heroes

- **URL**: `/api/heroes/seed-heroes`
- **Method**: `POST`
- **Description**: Seeds the database with a list of hardcoded heroes.


# Note
This Repo gonna be my starting point to learn Entity Framework and LINQ so its quite basic as of now.