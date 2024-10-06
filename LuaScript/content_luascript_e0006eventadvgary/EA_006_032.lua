-- このluaスクリプトは、EA_006_032.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Antagonism")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101032","002","101032002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Sad02")

	--★★ガレス★★:えっと、コーンウォールであれとあれ<br>アストラットであれは買ったから…
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0320002")

-- ▼直接出力
PlayPartVoiceDirect("ガレス","0034")
-- ▲直接出力

	--★★ガレス★★:あと必要なのは――
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0320003")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:…弁当の材料の買い出しに<br>こんなにあちこち行く必要があるのか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0320004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ガレス★★:もちろん！<br>せっかくなら最高の食材を使いたいからな♪
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0320005")

	change_face(Actor001,"Smile")

	--★★ガレス★★:そのためには待ってるだけじゃ駄目だ<br>自分で探しに行かないと！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0320006")

-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0034")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:なるほど…？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0320007")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0048")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガレス★★:付き合ってくれてありがとう、ランスロット！<br>おかげでお弁当の材料、たっくさん買えたぞ♪
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0320008")

	change_face(Actor001,"Normal")

	--★★ガレス★★:あとは…
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0320009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_006_0320011","EA_006_0320012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Laugh")

	--★★ガレス★★:ランスロットはお花見ってしたことあるのか？
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0320015")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:花見…か
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0320016")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:あれを花見と言っていいのかはわからないが<br>それらしいものを昔したことがあるな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0320017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ガレス★★:そうなんだ。やっぱり、家族と？
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0320018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:…ああ。妹に<ruby=ねだ>強請</ruby>られてな<br>「家族でピクニックがしたい」と
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0320020")

	change_face(Actor001,"Smile")

	--★★ガレス★★:へぇ～…良い思い出だな♪
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0320022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Laugh")

	--★★ガレス★★:ランスロットはどんなお弁当がいい？<br>リクエスト、聞くぞ♪
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0320025")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:特にこれといった希望はないが…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0320026")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:…強いて言えば、アーサーが好むB級グルメは<br>少な目にしてもらえると助かる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0320027")

	change_face(Actor001,"Surprise")

	--★★ガレス★★:嫌いなのか？
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0320028")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:そういうわけではないが…<br>…食べると、胃がもたれる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0320029")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ガレス★★:…あ！そうだ！思い出した！<br>あとはロンディニウムに行かないとだ！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0320031")

	change_face(Actor001,"Smile")

	--★★ガレス★★:確かロンディニウムにはすっごく美味しい<br>チーズのお店があるらしいんだ～♪
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0320032")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガレス★★:そこで売ってるブルーチーズが<br>ちょっとクサいけど美味しいらしくて――
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0320033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Antagonism")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("市民_男1","0031")
-- ▲直接出力

	--★★？？？★★:た、助けてくれえええ！
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","EA_006_0320035")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Surp")
PlayActionDirect(Actor002,"to  Std_Surp")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガレス／ランスロット★★:！
	Talk(Actor003,"CHRNAME_GARETH_LANCELOT","speech","L","EA_006_0320036")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ガレス――
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0320037")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ガレス★★:今の声――あっちだ！ <br>早く助けに行くぞ～！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0320038")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,346,0.3)
wait_time(0.3)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,345,0.3)
PlayActionDirect(Actor001,"to Run")
slidemove(Actor001,{-1.53, 0, 9.65}, 1.1)
wait_time(0.3)
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002,{-3.53, 0, 9.4},1.1)
wait_time(0.8)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Antagonism")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101032","002","101032002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
