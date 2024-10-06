-- このluaスクリプトは、EA_053_046.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_001,"content_motion3d_advarea_common_adv_templatecontroller","e0053_01_m_Controller","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_003)
	Camera004 = SetTemplate("Actor005",nil,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_020_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
-- ▼直接出力
turn_chara(Actor001,70,0)
PlayActionDirect(Actor001,"to Std_Whisk02do_Start")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	Actor005 = InitializeCharacter_3D("401029","001","401029001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(1.2)
setup_small_camera_start(Camera001)
wait_time(1.6)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ガウェイン★★:
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0460002")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★リオネス★★:
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","EA_053_0460004")

	change_face(Actor002,"Normal")

	--★★リオネス★★:街から戻ってきたと思ったら、いきなり<br>ものすごい勢いでお菓子を作り出したぞ
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","EA_053_0460005")

-- ▼直接出力
setup_small_camera_end(Camera001)
setup_small_camera_start(Camera005)
-- ▲直接出力

	--★★コック長★★:
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0460006")

-- ▼直接出力
setup_small_camera_end(Camera005)
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ガウェイン★★:ノワール、こっち頼む！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0460007")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor001,0.4)
wait_time(0.4)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
	change_face(Actor003,"Serious")

	--★★ノワール★★:了解！仕上げは任せたぞ！
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0460008")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
wait_time(0.4)
set_animationcontroller(Actor001, "Chr_003_01_StdController","to Std_Loop")
turn_lookat(Actor001,Actor005,0)
turn_lookat(Actor003,Actor005,0.4)
　set_common_look_at(Actor001,Actor005)
wait_time(0.4)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor001,"Anger")
	change_face(Actor001,"Normal")

	--★★ガウェイン★★:おう！<br>――うおおおおおおおおおおっ！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","N","EA_053_0460009")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(RndCamera003)
setup_small_camera_start(RndCamera005)
wait_time(0.4)
-- ▲直接出力
	close_cutin()
-- ▼直接出力
wait_time(0.8)
se_play("SE_ADV_EA_053_046_Oven")
wait_time(2.0)
hide_image(BLACK_WHITE_TIME)
wait_time(1.2)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Serious")

	--★★ガウェイン★★:――どうだ！！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0460013")

	change_face(Actor005,"Anger")

	--★★コック長★★:
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0460014")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor005,"to Std_HaveItem")
wait_time(1.6)
PlayActionDirect(Actor005,"to Std_HaveItem_Eat")
wait_time(3.2)
-- ▲直接出力

	--★★コック長★★:
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0460016")

-- ▼直接出力
setup_small_camera_end(RndCamera005)
-- ▲直接出力

	--★★ノワール/ガウェイン/リオネス★★:（ゴクリ…）
	Talk(Actor004,"CHRNAME_NOIR_GAWAIN_LYONESS","mind","L","EA_053_0460017")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.8)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0008")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★コック長★★:
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0460018")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0011")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0460019")

	PlayAction(Actor002,"to  Std_Appl")
-- ▼直接出力
PlayPartVoiceDirect("リオネス","0011")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リオネス★★:やったな！ガウェイン！
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","EA_053_0460020")

	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:おうよ！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0460021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Laugh")

	--★★ノワール★★:よかった…でも前に作ったのとなにが違うんだ？<br>見た目は同じに見えるんだけど
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0460024")

	change_face(Actor005,"Normal")

	--★★コック長★★:確かに見た目はどっちもよくできてるよ<br>なまじガウェインは料理が上手いからな
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0460025")


	--★★コック長★★:けど…最初に作った方には迷いがあっただろ<br>「これってヒーローのやることか？」――ってな
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0460026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:あ…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0460027")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)

	--★★コック長★★:そういうのはさぁ、やっぱり出ちまうんだよ<br>どんなに上手く誤魔化しても
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0460028")


	--★★コック長★★:対しておまえさんの作ったお菓子は<br>不格好ではあったけど精一杯の真心があった
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0460029")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Smile")

	--★★コック長★★:
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0460030")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0046")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ノワール★★:心で…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0460031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★コック長★★:ヒーローの熱い心が込められたお菓子か<br>――五月祭の目玉、間違いなしだぜ
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0460032")

	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0011")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★コック長★★:こりゃ、食堂の特別メニューも<br>負けてらんねェな！
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0460033")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401029","001","401029001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
