-- このluaスクリプトは、EA_007_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_005)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0.2)
turn_lookat(Actor003,Actor002,0.2)
turn_lookat(Actor002,Actor003,0.2)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor002)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor003,Actor002)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0031")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Anger")
	change_face(Actor002,"Normal")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","N","EA_007_0110005")

	close_cutin()
	PlayAction(Actor003,"to  Std_Talk")

	--★★ガウェイン★★:大変ってなにがだ？<br>雪でも積もったか？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_007_0110006")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0019")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラグネル★★:雪のことじゃないよ！<br>もう１２月だもん、雪が積もっても変じゃない！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0110008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0033")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:じゃあなんなんだ？<br>ラグネル、落ち着いて話してくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_007_0110009")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0021")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラグネル★★:お幸せにってカンジなの！！！！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0110011")


	--★★ラグネル★★:どうしよう！！！！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0110013")

-- ▼直接出力
set_enable_auto_lookat_all(true)
set_common_look_at(Actor001,Actor003)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ガウェイン…<br>ラグネルはどうしちゃったんだ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_007_0110015")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0034")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:さあ…？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_007_0110016")

	PlayAction(Actor002,"to Annoyed")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0022")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラグネル★★:アアっ！！！！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0110018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0033")
-- ▲直接出力

	--★★ガウェイン★★:ラグネル…俺たちはさ？<br>来たるローマとの決戦inカレドニアに向けて…
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_007_0110020")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ガウェイン★★:精神をさ、こう…高めてくべき時期だろ？今は
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_007_0110021")

	change_face(Actor003,"Normal")

	--★★ガウェイン★★:ノワールもギネヴィアと<ruby=ゲシュタルト・シフト>ＧＳ</ruby>して<br>色々あったわけだし
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_007_0110022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガウェイン★★:俺たちだって<br>色々あったじゃねーか、色々
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_007_0110024")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:だからさ、今は落ち着こうぜ<br>大体、なにそんなに慌ててんだよ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_007_0110027")

	PlayAction(Actor002,"to  Std_Joy")

	--★★ラグネル★★:しょーがないでしょ！<br>あわてんぼうのラグネルにもなるよ！！！！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0110028")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:落ち着いて、説明してくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_007_0110029")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ラグネル★★:じゃあ説明するけど<br>驚かないでよ
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0110030")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0008")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:驚かねーよ。なにがあったって
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_007_0110031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0034")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラグネル★★:クラリスちゃんに、隠し子がいたの！！！！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0110032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	open_cutin(2,2)
	on_cutin(1,Actor001,"Surprise")
	on_cutin(2,Actor003,"Surprise")

	--★★ノワール／ガウェイン★★:なァにィ～～～～！？
	Talk(Actor004,"CHRNAME_NOIR_GAWAIN","speech","N","EA_007_0110033")

	close_cutin()
	open_select_window_tag(Actor001,"Normal","EA_007_0110035","EA_007_0110036")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なんか…以前に<br>似たようなことで驚いた記憶が………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_007_0110039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0020")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:そりゃ誰だって驚くだろ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_007_0110040")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0040")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや…えーっと<br>なんか、誤解だったりしないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_007_0110041")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0029")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:証拠は！？<br>なにか証拠はあるのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_007_0110044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0019")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラグネル★★:あたしの言うことが信じられないの！？
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0110045")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0041")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:ちゃんとした証拠がねーと<br>信じられねえよ！！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_007_0110046")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0039")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラグネル★★:じゃあふたりとも、ついてきて！<br>慌てずにね！！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_007_0110048")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
