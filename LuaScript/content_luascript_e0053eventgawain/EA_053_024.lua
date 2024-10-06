-- このluaスクリプトは、EA_053_024.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	Camera002 = SetTemplate("Actor002",180,CharaPos110122_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_006)
	Camera003 = SetTemplate("Actor003",74,CharaPos110122_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_020_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_002)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor001,"J_Head")
lookat_weight(Actor004,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0008")
-- ▲直接出力

	--★★コック長★★:よく来たな、ヒーロー！<br>と、そのお友達！
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0240002")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0032")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガウェイン★★:…なんか嫌な予感してきたな
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0240003")

-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0010")
-- ▲直接出力

	--★★コック長★★:頼みってのはほかでもない…
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0240004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★コック長★★:五月祭で街の皆に配る<br>お菓子作りを手伝ってほしいんだ！
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0240005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リオネス_003","0009")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リオネス★★:だ！！
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","EA_053_0240006")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガウェイン★★:やっぱりか！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0240007")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0033")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガウェイン★★:お菓子作りって！<br>それヒーローに頼むことか！？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0240008")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor004,true)
lookat_delay_weight_reset(Actor004,1.0)
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力

	--★★ノワール★★:確かにヒーローっぽくはないかも
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0240009")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0015")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★コック長★★:なにを言う<br>街の皆を笑顔にする大切な仕事だぞ！
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0240010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0051")
-- ▲直接出力

	--★★ガウェイン★★:それはそうだけどヒーローの仕事じゃなくね？<br>料理人の仕事だろ！！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0240011")

	change_face(Actor004,"Normal")

	--★★コック長★★:オレっちとガレスは祭り当日に食堂で出す<br>料理の仕込みで忙しいんだよ！
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0240012")


	--★★コック長★★:リオネスに任せようかとも思ったんだが…
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0240013")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("リオネス_003","0033")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リオネス★★:ところがあたしは壊滅的に料理が下手だ！<br>だから…ヒーローを頼ることにした！
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","EA_053_0240014")


	--★★リオネス★★:ガウェインが料理上手なことは<br>ガレスから聞いて知ってたからな！
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","EA_053_0240015")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力

	--★★ノワール★★:へえ、そうなのか
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0240016")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガウェイン★★:…まぁ、少なくとも<br>リオネスよりはできるけどさぁ…
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0240017")


	--★★コック長★★:頼むよヒーロー！五月祭を成功させるために<br>おまえさんの力が必要なんだ！
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0240018")

-- ▼直接出力
PlayPartVoiceDirect("リオネス_003","0042")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リオネス★★:頼むぞヒーロー！
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","EA_053_0240019")

-- ▼直接出力
setup_small_camera_end(RndCamera007)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0043")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ガウェイン★★:だあ～！もう、わかったよ！<br>そこまで頼み込まれちゃ断れねえ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0240020")

	open_cutin(2,1)
	on_cutin(1,Actor004,"Smile")
	on_cutin(2,Actor002,"Smile")

	--★★コック長＆リオネス★★:やったー！
	Talk(Actor005,"CHRNAME_0260_LYONESS","speech","L","EA_053_0240021")

	close_cutin()
	change_face(Actor001,"Sad")

	--★★ガウェイン★★:けどさすがに作る量が多すぎるぜ…
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0240022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ノワール★★:なら、俺が手伝おうか？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0240023")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガウェイン★★:え！？いいのか！？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0240024")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ノワール★★:ああ、もちろん<br>むしろそのつもりで来たからな
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0240025")

	change_face(Actor003,"Normal")

	--★★ノワール★★:（まさかお菓子作りをすることになるとは<br>思わなかったけど…）
	Talk(Actor003,"CHRNAME_NOIR","mind","L","EA_053_0240026")

-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
lookat_delay_weight_reset(Actor002,1.0)
PlayPartVoiceDirect("グリフレット","0042")
-- ▲直接出力

	--★★コック長★★:ふたりとも、サンキュー！<br>これで五月祭の準備はバッチリだぜ！
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0240027")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,120,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リオネス★★:それじゃあたしはチラシを町中に配って<br>お菓子の宣伝をしてくるな
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","EA_053_0240028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("リオネス_003","0011")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リオネス★★:なんだかワクワクしてきたぞ！<br>五月祭が楽しみだー！
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","EA_053_0240029")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayPartVoiceDirect("ガウェイン","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガウェイン★★:でもやっぱ、これって<br>ヒーローの仕事じゃねー気がするけど…
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0240030")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
