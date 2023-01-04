<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/jconnelly-dev/MeadowsDeviceAPI">
    <img src="logo.png" alt="project logo image" width="80" height="80">
  </a>
  <h3 align="center">MeadowsDeviceAPI</h3>
  <p align="center">
    Personal project using meadow f7v2 feather to create a gps mobile app.
  </p>
</div>


<!-- PROJECT DETAILS -->
## Project Details

This repo is intended to house the backend codebase for the public DeviceAPI.
* The API will be written in ASP.NET Core 7 and will provide public POST/GET RESTful methods.
* The POSTs will be used by the meadow f7v2 feather to save device data.
* Device data will be saved to a Mongo NoSQL database.
* The GETs will be used by a frontend mobile application that will consume the device data.
* The mobile application will be written in MAUI and that codebase will exist in a separate repo.
* This DeviceAPI will start off providing access via an IP address, but will eventually use a custom domain when I buy one from GoDaddy.
* I haven't yet decided if I will host this API in Heroku, or AWS.
* Heroku is easiest for me since I've done this before, but I'd like to start using AWS more.
  
  
<!-- CONTACT -->
## Contact

Joseph Connelly - [@personal_email](joseph_a_connelly@yahoo.com)

Project Link: [@github_repo](https://github.com/jconnelly-dev/MeadowsDeviceAPI)

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://github.com/jconnelly-dev/MeadowsDeviceAPI/contributors.svg?style=for-the-badge
[contributors-url]: https://github.com/jconnelly-dev/MeadowsDeviceAPI/graphs/contributors
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: www.linkedin.com/in/joseph-a-connelly

