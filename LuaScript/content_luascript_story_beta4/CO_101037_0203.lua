-- このluaスクリプトは、CO_101037_0203.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_03","110111_03_h")
Include("content_adv_advsmall_110111_03","Template110111_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_003)
	InitializeTemplateRandomCamera110111_03()
	InitializeTemplate110111_03()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
 lookat_weight(Actor001,1.0,0.05,0.5,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ラシアのおかげでいい手袋が買えたよ<br>他にも面白そうな店をたくさん教えてもらったし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02030002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:いえ、お役に立てて良かったです！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:お礼と言ってはなんだけど<br>今度は俺がラシアの買い物に付き合うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02030004")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Surprise")

	--★★ラシア★★:そんな、気にしないでください
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02030005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:でも…せっかくだから<br>お言葉に甘えさせてもらってもいいですか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02030006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:お安い御用さ<br>用事があるのはどの店だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02030007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力

	--★★ラシア★★:街はずれに牛を飼ってる方がいて<br>そこで牛乳をもらってこようかと
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02030008")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:飲むのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02030009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "否定")
-- ▲直接出力

	--★★ラシア★★:新鮮な牛乳を分けてもらって<br>ヨーグルトを作るんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02030010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ラシア★★:いつもたくさん作るので<br>結構な量の牛乳を運ぶ必要があって
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02030011")


	--★★ラシア★★:荷物を持ってくれる人がいると<br>助かるんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:お任せあれ。騎士たる者<br>女性を助けるのが務めですから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_02030013")

-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力

	--★★ラシア★★:ふふっ、なんですかそれ<br>
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_02030014")

-- ▼直接出力
local trustParam = set_communication_acquired("ラシア_コミュランク", "ラシア_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
