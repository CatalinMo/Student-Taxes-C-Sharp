import { Options, Vue } from 'vue-class-component';
import MainNavComponent from '../main-nav/index.vue';
import ScrollToTopComponent from '../scroll-to-top/index.vue';

@Options({
    components: {
        'main-nav': MainNavComponent,
        'scroll-to-top': ScrollToTopComponent
    },
})
export default class MainContentComponent extends Vue {}
