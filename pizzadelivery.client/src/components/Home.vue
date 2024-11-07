<template>
  
  <Navbar/>
  <Carousel/>
</template>


<script>
  import Navbar from './Navbar.vue'; 
  ///import Section from './Section.vue'; 
  import Carousel from './Carousel.vue';
  export default {
    name: 'Home',
    components: {
      Navbar,
      Carousel
    },
  };
</script>


<style>



</style>
