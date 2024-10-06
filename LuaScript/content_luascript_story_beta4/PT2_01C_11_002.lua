-- このluaスクリプトは、PT2_01C_11_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:おはよう、兄さん<br>私の準備は済んでるよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01C_11_002006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ああ、こっちもバッチリだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01C_11_002007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:でも、ディナタン<br>本当に体は大丈夫なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01C_11_002008")


	--★★ノワール★★:もしもまだあまり体調が良くないなら<br>学園で待機していてくれてもいいんだぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01C_11_002009")


	--★★ディナタン★★:もう、兄さんってば心配性なんだから…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01C_11_002010")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:私なら、すっかりもとどおり！<br>むしろ休ませてもらったぶん、前より元気かも！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01C_11_002011")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:それに、魔女は<br>ルーシャス皇太子を助けたいのなら
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01C_11_002012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:私と兄さんを<br>カレドニア城に連れて来いって言ってるんでしょ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01C_11_002013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:だったら<br>私が行かないわけにはいかないよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01C_11_002014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:ああ、そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01C_11_002015")


	--★★ノワール★★:…わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01C_11_002016")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:フレンさんたちは<br>先に出て門のあたりで待っててくれてるみたい
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01C_11_002017")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:すぐに出よう<br>あまり待たせるちゃ悪いもんな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01C_11_002018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
