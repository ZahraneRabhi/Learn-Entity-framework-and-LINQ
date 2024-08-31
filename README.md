# LEARN-LINQ Repo

This solution is designed to help me learn and practice [Entity FrameWork](https://learn.microsoft.com/en-us/aspnet/entity-framework) and [LINQ](https://learn.microsoft.com/en-us/dotnet/csharp/linq/) (Language-Integrated Query) in C#. It includes a simple API for managing heroes, inspired by characters from 'The Boys' series.

<p align="center">
  <img src="https://i.giphy.com/media/v1.Y2lkPTc5MGI3NjExcG9jYjFrbzR2YWVtN2d1YXNvaTFyZnRjazQ2Njc3Z2VhNWp2MzZnZSZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9dg/KMikhPf3RV7pRAJ1YW/giphy.gif" alt="Homelander">
</p>

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
This Repo gonna be my starting point to learn Entity Frameword and LINQ so its quite basic as of now.