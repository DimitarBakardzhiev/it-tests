<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of BaseController
 *
 * @author Samuil.Petrow
 */
class BaseController {
    function Render($viewName){
        include '../views/' . $viewName . 'View.php';
    }
}
