-- このluaスクリプトは、MA_01A109_11.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110171_02","110171_02_h")
Include("content_adv_advsmall_110171_02","Template110171_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",40,CharaPos110171_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110171_02,CameraPos110171_02_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110171_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110171_02,CameraPos110171_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110171_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110171_02,CameraPos110171_02_006)
	InitializeTemplateRandomCamera110171_02()
	InitializeTemplate110171_02()
-- ▼直接出力
set_common_look_at(Actor001,Actor002,1.0) 
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1.0) 
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor003,Actor002,1.0) 
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115174)
	Actor001 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
set_common_look_at(Actor001,Actor002)
set_common_look_at(Actor002,Actor001)
set_common_look_at(Actor003,Actor002)
 --PlayPartVoice("ローラ", "肯定")
-- ▲直接出力

	--★★ローラ★★:私、どこだっていい<br>お姉ちゃんとなら
	Talk(Actor001,"CHRNAME_LOLA","speech","L","MA_01A109_110002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フレン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:ローラ<br>貴方は自分で決めることを覚えて
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_110003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ローラ★★:お揃いの道を行くよ。お姉ちゃんと
	Talk(Actor001,"CHRNAME_LOLA","speech","L","MA_01A109_110004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラシア★★:…本当に信じているわけじゃないよね？<br>あの虐殺が…ログレスの仕業だなんて
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01A109_110005")

-- ▼直接出力
 --PlayPartVoice("フレン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:敵国ローマをブリテンから追い出すために…<br>…とか、動機がないことはないよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_110006")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Anger")

	--★★ラシア★★:その実…ローマが仕組んだという話もある
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01A109_110007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フレン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:ローマ人がローマ人を虐殺したって言うの？
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_110008")

-- ▼直接出力
 --PlayPartVoice("ローラ", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ローラ★★:そんなことしてなんになるの？<br>もともとローマ領で街の名前の由来だって…
	Talk(Actor001,"CHRNAME_LOLA","speech","L","MA_01A109_110009")

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,0.7,0.5,0.7,0.5)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.3)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:ラシア、貴方はどっちを信じるの？
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_110010")

-- ▼直接出力
 --PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Surprise")

	--★★ラシア★★:え…？
	Talk(Actor003,"CHRNAME_RASIA","speech","N","MA_01A109_110011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	close_cutin()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★フレン★★:恩義ある貴方の叔父か<br>居心地の良い、この学園か
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_110012")

-- ▼直接出力
 --PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラシア★★:…あなたたちこそ
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01A109_110013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:鳥のなかにはさ
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_110015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★フレン★★:産まれたときに目に入った相手に<br>ついてく習性のある子がいるんだって
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_110016")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★フレン★★:相手がたとえ別世界の存在でもね
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_110017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラシア★★:あなたは赤子でもなければ<br>翼も持ってはいないでしょ？
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01A109_110018")

-- ▼直接出力
 --PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:うん、産まれたてなんかじゃないから<br>自分の目で確かめてみたいの
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_110019")


	--★★フレン★★:翼なんてないから<br>羽ばたくことなんて出来ないから
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_110020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Sad")

	--★★フレン★★:道を踏み外したら終わりだね
	Talk(Actor002,"CHRNAME_FREN","speech","N","MA_01A109_110021")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115174)
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110171_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
