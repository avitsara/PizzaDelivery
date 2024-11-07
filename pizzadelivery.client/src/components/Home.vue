<template>
  
  <Navbar/>
  <Carousel/>
  <Footer/>
</template>


<script>
  import Navbar from './Navbar.vue'; 
  ///import Section from './Section.vue'; 
  import Carousel from './Carousel.vue';
  import Footer from './Footer.vue';
  export default {
    name: 'Home',
    components: {
      Navbar,
      Carousel,
      Footer
    },
  };
</script>


<style>



</style>
