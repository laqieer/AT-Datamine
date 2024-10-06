-- このluaスクリプトは、CO_101062_0303.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114071_01","114071_01_h")
Include("content_adv_advsmall_114071_01","Template114071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114071_01,CameraPos114071_01_004)
	Camera002 = SetTemplate("Actor002",125,CharaPos114071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName114071_01,CameraPos114071_01_003)
	InitializeTemplateRandomCamera114071_01()
	InitializeTemplate114071_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002,0.9,0.01,0.9,0.2)
keep_delay_ik_lookat(Actor002,Actor001, "J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("マルイル", "落胆")
-- ▲直接出力

	--★★マルイル★★:ふぅ…お客さんの欲しいものを無事に仕入れられてよかったです！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:これも、ノワールさんのおかげですね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺はあんまり役に立ってない気がするけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_03030004")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ところで、ここはなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_03030005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:ここはローマン・バスといって、ぼくのおすすめスポットです！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030006")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マルイル★★:長く歩いて疲れましたし、ここでちょっと汗を流していきましょう！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030007")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
se_play("SE_ADV_MA_01B112_49_Cloth")
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN + 1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
se_play("SE_ADV_MA_01108_20_Water_02")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:うわっ！？　
	Talk(Actor001,"CHRNAME_NOIR","speech","N","CO_101062_03030009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力

	--★★マルイル★★:ん？どうしたんですか？
	Talk(Actor002,"CHRNAME_MARIL","speech","N","CO_101062_03030010")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:あんた、すごい筋肉だな！？全然そんなふうに見えなかった…
	Talk(Actor001,"CHRNAME_NOIR","speech","N","CO_101062_03030011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "喜び")
-- ▲直接出力

	--★★マルイル★★:あはは。ぼく、着やせするタイプなんですよ～
	Talk(Actor002,"CHRNAME_MARIL","speech","N","CO_101062_03030012")


	--★★マルイル★★:世界中を行商してたときに色々と危険なこともあったので、鍛えるようにしてるんです
	Talk(Actor002,"CHRNAME_MARIL","speech","N","CO_101062_03030013")

	change_face(Actor002,"Smile")

	--★★マルイル★★:「商人たるもの、体が資本！」そう祖父に教えられて
	Talk(Actor002,"CHRNAME_MARIL","speech","N","CO_101062_03030014")

-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:実際、行商のときに健康の大切さを実感しましたよ
	Talk(Actor002,"CHRNAME_MARIL","speech","N","CO_101062_03030015")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:確かに半端な野盗では相手にならなかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","N","CO_101062_03030016")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
se_play("SE_ADV_MA_01B112_49_Cloth")
hide_image(BLACK_WHITE_TIME)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME + 1.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:ふー。いいお湯でしたね～
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030018")

	open_select_window_tag(Actor001,"Normal","CO_101062_03030020","CO_101062_03030021")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ。だいぶリフレッシュできたよ教えてくれてありがとう、マルイル
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_03030023")

-- ▼直接出力
PlayPartVoice("マルイル", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:いえいえ！お気に入りの場所はみんなに知ってもらいたいですから
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030024")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★マルイル★★:それに、ノワールさんの疲れを癒してもらうのはぼくのためでもあるので
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030025")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_03030026")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:もっと熱くてもよかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_03030028")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:ええっ…！ぼくはあのお湯でも充分熱いと思ったんですけど…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030029")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:熱い風呂に、熱い熱いって言いながら入るのが気持ちいいんじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_03030030")

-- ▼直接出力
PlayPartVoice("マルイル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:ノワールさん…なんか、おじいちゃんみたいですね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030032")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:さて、あとはログレスに帰るだけか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_03030034")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "気合い")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルイル★★:さて…、一息ついたらもうひと仕事いきましょうか！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？もうひと仕事って…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_03030036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:せっかくプロの傭兵に護衛してもらってるのに<br>これだけで終わるなんてもったいないでしょ！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030037")

	change_face(Actor002,"Normal")

	--★★マルイル★★:それにバルバロイが出たら、ぼくひとりでは逃げるしかできませんから
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030038")


	--★★マルイル★★:だから危険地帯も含め、いろんな場所に行ってたっくさん仕入れたいんです！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030039")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:構いませんよね、ノワールさんっ！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:えええ…でも俺、もう帰りつもりだったっていうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_03030041")


	--★★ノワール★★:風呂でだいぶまったりしちゃったし危険地帯に行くようなテンションじゃ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_03030042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:そんなこと言わずに、お願いします！ノワールさんだけが頼りなんですよ～！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030043")


	--★★ノワール★★:（マルイルの狙いはこれだったのか…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101062_03030044")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:…わかったわかった付き合えばいいんだろ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_03030046")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:やったー！ありがとうございます！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030047")

-- ▼直接出力
PlayPartVoice("マルイル", "気合い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:さあ、そうと決まれば急いで出発しましょう！「時は金なり」、ですからね！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_03030048")

-- ▼直接出力
local trustParam = set_communication_rankup("マルイル_コミュランク", "マルイル_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 -- --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
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
	load_area_scene_preload(114071)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
