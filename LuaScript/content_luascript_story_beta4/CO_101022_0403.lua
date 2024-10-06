-- このluaスクリプトは、CO_101022_0403.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110031_01","110031_01_h")
Include("content_adv_advsmall_110031_01","Template110031_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110031_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_003)
	InitializeTemplateRandomCamera110031_01()
	InitializeTemplate110031_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:おせえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030002")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:モルドレッド！？い、いたのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:悪いかで、薬は？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:貰って来たよ…もう戻ったかと思ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04030006")


	--★★ノワール★★:もしかして、待ってたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04030008")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "否定")
-- ▲直接出力

	--★★モルドレッド★★:てめえのことは待ってねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030010")


	--★★ノワール★★:（薬は待ってたのか…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101022_04030011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:大切に思ってるんだよなクラリスのこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04030013")

-- ▼直接出力
PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:あ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…良かったら突然怒り出した理由を教えてくれないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04030015")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:なんでてめえにそんなこと教えなきゃならねえんだよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030016")


	--★★ノワール★★:別にいいだろ気になったんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04030017")

-- ▼直接出力
PlayPartVoice("モルドレッド", "否定")
-- ▲直接出力

	--★★モルドレッド★★:おめえには関係ねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101022_04030020","CO_101022_04030021")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:関係ないことはないだろ一緒に戦う仲間同士なんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04030023")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:てめえと仲間になったつもりなんかねえよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030024")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃあ、同じ円卓の騎士同士とか同じ学校に通う生徒同士ってことでどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04030025")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:チッ、ああ言えばこう言う…まったく調子狂うぜ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030026")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:さっきの療養院でのやりとりをクラリスに話したら、理由を教えてくれるかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04030028")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:てっ、てめえ！それは卑怯だろ！やめろ！絶対あいつには聞くんじゃねえ！！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030029")

	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃああんたが教えてくれよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04030030")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:おめえ…大したタマだな………
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030032")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:あいつは口癖みてえに「みなさんにシアワセ」なんて言いやがるがよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030034")


	--★★モルドレッド★★:本当はあいつ以上に不幸なヤツはいねえんだよ俺は少なくとも知らねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_04030036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:それなのにあいつは頑張っていつもみんなの前では笑顔でいやがる
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030037")


	--★★モルドレッド★★:頑張る必要なんてねえのによ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030038")


	--★★モルドレッド★★:俺はそれを知っていながらさらに頑張んなきゃならねえ道を選ばせちまった
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030039")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "落胆")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:…チッ余計なこと喋らせんじゃねえよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:あのガラの悪いオンナには謝っといてくれ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★モルドレッド★★:…じゃな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_04030042")

-- ▼直接出力
local trustParam = set_communication_rankup("モルドレッド_コミュランク", "モルドレッド_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
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
	load_area_scene_preload(110031)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 1
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
