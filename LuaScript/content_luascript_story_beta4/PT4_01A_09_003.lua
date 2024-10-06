-- このluaスクリプトは、PT4_01A_09_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",320,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
lookat_weight(Actor003,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:兄さん、あらためて<br>GSの達成、おめでとう
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","PT4_01A_09_0030002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ありがとう。少し時間がかかっちゃったけど<br>これでようやくスタートラインに立てたのかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_09_0030003")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:そうだな<br>次はいよいよ継承者の使命を果たすわけだが…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT4_01A_09_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:今の状況を考えると<br>それは一筋縄ではいかないだろうな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT4_01A_09_0030005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ。聖杯を探さなければならないし<br>ローマに魔女、倒すべき敵もまだまだ大勢いる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_09_0030006")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:これから先<br>たくさんの困難が待ってると思うけど
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","PT4_01A_09_0030007")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:兄さんとギネヴィアさんなら<br>きっと大丈夫だよ
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","PT4_01A_09_0030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:そうだな<br>もしも立ち止まりそうになってしまったときでも
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT4_01A_09_0030009")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:彼女なら、あの溢れる行動力で<br>お前を引っ張って行ってくれるはずだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT4_01A_09_0030010")

-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定2")
-- ▲直接出力

	--★★ディナタン★★:ギネヴィアさんを信じて<br>兄さんは前だけを向いて歩いていって
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","PT4_01A_09_0030011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:背中は俺たちが支える
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT4_01A_09_0030012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう、ふたりとも<br>これからもよろしく頼むよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_09_0030013")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
