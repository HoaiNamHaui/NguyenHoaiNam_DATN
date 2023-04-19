<template>
<div class="container">
  <the-header />
  <div style="display: flex;">
    <the-sidebar />
    <the-content />
  </div>
</div>
  
</template>

<script>
import TheHeader from './components/layout/TheHeader.vue'
import TheSidebar from './components/layout/TheSidebar.vue'
import TheContent from './components/layout/TheContent.vue'

export default {
  name: 'Admin',
  components: {
    TheHeader,
    TheSidebar,
    TheContent
  }
}
</script>

<style>
@import url(./css/main.css);
</style>