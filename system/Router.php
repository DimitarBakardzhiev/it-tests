<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of Router
 *
 * @author Samuil.Petrow
 */
class Router {

    function parse_path() {
        $path = array();
        if (isset($_SERVER['REQUEST_URI'])) {
            $request_path = explode('?', $_SERVER['REQUEST_URI']);

            $path['base'] = rtrim(dirname($_SERVER['SCRIPT_NAME']), '\/');
            $path['call_utf8'] = substr(urldecode($request_path[0]), strlen($path['base']) + 1);
            $path['call'] = utf8_decode($path['call_utf8']);
            if ($path['call'] == basename($_SERVER['PHP_SELF'])) {
                $path['call'] = '';
            }
            $path['call_parts'] = explode('/', $path['call']);

            $path['query_utf8'] = urldecode($request_path[0]);
            $path['query'] = utf8_decode(urldecode($request_path[0]));
            $vars = explode('&', $path['query']);

            foreach ($vars as $var) {
                $t = explode('=', $var);
                $path['query_vars'][$t[0]] = $t[0];
            }
        }
        return $path;
    }

    function route() {
        $path_info = self::parse_path();

        switch ($path_info['call_parts'][0]) {
            case 'test': include '../controllers/TestController.php'; 
                $controller = new TestController();
                break;
            default:
                include '../controllers/DefaultController.php';
                $controller = new DefaultController();
        }
    }

}
