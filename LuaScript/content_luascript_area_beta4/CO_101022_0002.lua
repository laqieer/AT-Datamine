-- このluaスクリプトは、CO_101022_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_01","112041_01_h")
Include("content_adv_advsmall_112041_01","Template112041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName112041_01,CameraPos112041_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName112041_01,CameraPos112041_01_003)
	InitializeTemplateRandomCamera112041_01()
	InitializeTemplate112041_01()
-- ▼直接出力
lookat_delay_weight(Actor002,0.8, 0.3, 0.6,0.3,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor001, 0.8, 0.3, 0.6, 0.3,1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:奢ってくれるみてえだから贅沢は言わねえがよ誰かを連れてくんなら、店は考えて選べよ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010008")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ああ、ごめんこの店は嫌いだったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_00010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:嫌いじゃねえよ何度も何度も来てるってだけだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010010")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:メニュー貸せ俺が選んでやる
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010011")

-- ▼直接出力
PlayPartVoice("モルドレッド", "悩む")
-- ▲直接出力

	--★★モルドレッド★★:食前に飲むドリンクはこれで…前菜はこれで…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010012")

	change_face(Actor001,"Smile")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_00010013")

-- ▼直接出力
PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:あ？なんだそのツラは
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:こんな店でもメニューの順番にこだわるなんて育ちがいいんだなと思ってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_00010015")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:気まぐれな道化師の連中がここに来るとメチャクチャな頼みかたするからよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★モルドレッド★★:自然と俺が選んでやるようになっただけだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010017")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ。でも意外だなあんたはもっと一匹狼で
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_00010018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:こんな店に来てみんなと騒ぐことなんてないと思ってたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_00010019")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:自分で馬鹿騒ぎする気はねえが馬鹿騒ぎしてんのを見るのは嫌いじゃねえよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★モルドレッド★★:…静かでお堅くて気取ってるよりよっぽどいい
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101022_00010022","CO_101022_00010023","CO_101022_00010024")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺も食事は賑やかなほうが好きだなみんなとワイワイ喋りながら食べたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_00010026")

	change_face(Actor001,"Smile")

	--★★ノワール★★:傭兵やってた時代は団のみんなといつも大騒ぎしてたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_00010027")

-- ▼直接出力
PlayPartVoice("モルドレッド", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:はっ、おめでてえヤツだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:でもよオレとじゃ賑やかなメシにはならねえだろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:まず、オレとてめえじゃ合う話題がねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:合う話題を見つけるのも誰かと食事をする目的のひとつじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_00010031")

-- ▼直接出力
PlayPartVoice("モルドレッド", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:…つくづく、おめでてえヤツだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010032")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どうかしたか？…俺、なんか余計なこと言っちゃったかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_00010035")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:別に、大したことじゃねえよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010036")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:つまんねえこと思い出しちまっただけだ…覚えておく必要もねぇ、くだんねえ過去を
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010037")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ふうん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_00010038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:飲めよ、ジンジャーエール嫌な思い出も、酔ったら忘れられるだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_00010039")

-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:そんなもんで酔えるか！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010040")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん俺は食事は少人数で静かにするのが好きだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_00010043")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そのほうが味に集中できる気がしないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_00010044")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:料理の味なんてハラに入ったらどれも一緒だろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_00010045")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ガレスの前でその発言は控えたほうがいと思うぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_00010046")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"モルドレッド")
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
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
