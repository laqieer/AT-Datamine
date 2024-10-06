-- このluaスクリプトは、EA_053_043.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_020_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
-- ▼直接出力
hideobj01 = get_object("geo_uv03_obj01_foodA")
set_pos(hideobj01, {0,-20, 0})
set_pos(Actor003,{5.74, 0, -1.85})
turn_chara(Actor003,180,0)
set_pos(Actor004, {2.52, 0, -8.318})
turn_chara(Actor004,92,0)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
load_image("104000340", "content_still_10400034_image", "104000340_StillImage")

load_image("104000350", "content_still_10400035_image", "104000350_StillImage")

load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
meal01 = setup_prop_object(10104006)
set_pos(meal01,{6.908, 1.016, -7.575})
set_rot(meal01,{0,0,0})
-- ▲直接出力
-- ▼直接出力
Hide(meal01)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:…よし！<br>あとは焼き上がりを待つだけだな
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0430003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:すでにバターの香りが漂ってきてるな<br>すごく美味しそうな匂いだ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0430004")


	--★★ノワール★★:今すぐ食べたいくらいだ<br>やっぱりガウェインは料理が上手いよなぁ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0430005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力

	--★★ガウェイン★★:ノワールだって1日でかなり上達したな<br>きっとコック長も喜ぶぜ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0430006")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(1 + 0.2)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(0.8 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
--オーブンの音
se_play("SE_ADV_EA_053_046_Oven")
Appear(meal01)
hide_image(BLACK_WHITE_TIME)
wait_time(1.0)
Appear(Actor003)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{5.791, 0, -6.664}, 2.0)
wait_time(2.0)
turn_chara(Actor003,120,0.5)
wait_time(0.5)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★リオネス★★:おまたせ！コック長を呼んできたぞ！<br>それじゃ、早速お菓子の確認をしてもらおう！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_053_0430008")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor004)
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,{5.795, 0, -8.318}, 2.0)
wait_time(2.0)
turn_chara(Actor004,40,0.5)
wait_time(0.5)
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0008")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★コック長★★:おお！ずいぶん頑張ってくれたじゃねぇか<br>んじゃさっそく――
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0430009")

-- ▼直接出力
CloseTalkWindow() 
fadeout(0,0,0,0.2, 0.2)
wait_time(1 + 0.2)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(0.8 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_EA_053_046_Cookie_Eat")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★コック長★★:パクッ…もぐもぐ………
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0430010")

	change_face(Actor002,"Anger")

	--★★ノワール★★:（ゴクリ…）
	Talk(Actor002,"CHRNAME_NOIR","mind","L","EA_053_0430011")

-- ▼直接出力
se_play("SE_ADV_EA_053_046_Cookie_Eat")
-- ▲直接出力

	--★★コック長★★:………うん
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0430012")

-- ▼直接出力
CloseTalkWindow() 
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:ど、どうだ？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0430013")

-- ▼直接出力
show_image("104000340", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0009")
-- ▲直接出力

	--★★コック長★★:…うん。まずノワールが作ったほう
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0430014")


	--★★コック長★★:
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0430015")

-- ▼直接出力
setup_small_camera_start()
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Smile")

	--★★コック長★★:基本に忠実で、丁寧に作ったことが伝わる<br>これなら自信をもって街の皆に配れるぜ！
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0430016")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0012")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:やったー！
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0430017")

-- ▼直接出力
show_image("104000350", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0007")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★コック長★★:で、ガウェインが作ったほうが――
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0430018")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Anger")

	--★★コック長★★:
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0430019")

-- ▼直接出力
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0028")

-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガウェイン★★:え？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0430020")


	--★★コック長★★:
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0430021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:そんな、なんで…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0430022")


	--★★コック長★★:客に出すものに妥協はできねぇ<br>今回はノワールが作った分だけ配ることにする
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0430023")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("リオネス_003","0018")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リオネス★★:でもそれじゃ、数が足りないぞ<br>街の皆に行き渡らないかも
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_053_0430024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0007")
-- ▲直接出力

	--★★コック長★★:かもしれねぇな<br>けどしかたない
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0430025")

-- ▼直接出力
PlayPartVoiceDirect("リオネス_003","0024")
-- ▲直接出力

	--★★リオネス★★:しかたないって――
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_053_0430026")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0016")
PlayActionDirect(Actor001,"to Std_HaveItem")
-- ▲直接出力

	--★★ガウェイン★★:ちょ…ちょっと待てって！なんでだよ！？<br>ちゃんとできてるだろ！？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0430027")

-- ▼直接出力
PlayAction(Actor001,"to Std_HaveItem_Eat")
wait_time(1.0)
se_play("SE_ADV_EA_053_046_Cookie_Eat")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ガウェイン★★:見た目だって完璧だし、味だって――<br>…パクッ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0430028")

	change_face(Actor001,"Surprise")

	--★★ガウェイン★★:
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0430030")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ノワール★★:ガウェイン？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0430031")

-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0008")
-- ▲直接出力

	--★★コック長★★:
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0430032")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_HaveItem")
wait_time(2.5)
-- ▲直接出力
-- ▼直接出力
PlayAction(Actor001,"to Std_HaveItem_Eat")
wait_time(1.0)
se_play("SE_ADV_EA_053_046_Cookie_Eat")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガウェイン★★:…パクッ…もぐもぐ………
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0430034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★コック長★★:どうだ？
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0430035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガウェイン★★:………
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0430036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ガウェイン★★:…あんたの言いたいことはわかった
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0430037")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ガウェイン★★:確かに…俺が作ったほうは――<br>これじゃ出せねーかもしんねぇ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0430038")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力

	--★★ノワール★★:え…どうしてだ！？ガウェインのお菓子は<br>俺が作ったやつよりずっと美味しそうなのに
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_053_0430039")

-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0009")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★コック長★★:確かに見た目だけでいえば<br>ガウェインが作ったお菓子のほうがよくできてる
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0430040")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ガウェイン★★:けど…なんかが足んねーんだよ<br>それがなにかは、わかんねーけど…
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0430041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★コック長★★:街の様子を見に行ってみろ<br>そうすれば、きっと分かる
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0430042")


	--★★ガウェイン★★:………
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0430043")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("104000340", "content_still_10400034_image", "104000340_StillImage")
load_image_preload("104000350", "content_still_10400035_image", "104000350_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
setup_prop_object_preload(10104006)
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
