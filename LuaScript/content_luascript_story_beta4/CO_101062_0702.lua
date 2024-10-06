-- このluaスクリプトは、CO_101062_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_004)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力

	--★★マルイル★★:ノワールさんあの後、体の調子はいかがですか？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:あのマッサージのあとか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_07020003")

	open_select_window_tag(Actor001,"Normal","CO_101062_07020005","CO_101062_07020006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:痛すぎて死ぬかと思ったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_07020008")

-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:あはは。でも痛いくらいが効くっていうでしょ？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020009")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんなレベルの痛みじゃなかったぞ、あれは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_07020010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:今はだいぶ調子がいいよ肩凝りとか腰の痛みはすっかりなくなった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_07020012")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:そうでしょう、そうでしょうぼく、マッサージには自信あるんです！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020013")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（ただ、マッサージを受けている最中の痛みはこの世のものとは思えないものだったけど…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101062_07020014")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:職業柄ぼくも肩凝り腰痛には悩まされていましてね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020016")


	--★★マルイル★★:独学でマッサージのスキルを会得したんですよ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020017")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:よければまたやりましょうか？ノワールさん、いつも忙しそうですし
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020018")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:い、いや！いいっていいって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_07020019")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、そうだ！ところでこのあいだの素材は無事売れたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_07020021")

-- ▼直接出力
PlayPartVoice("マルイル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:あー…あれですか。実はまだなんです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020022")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:そうなのか。稀少素材って言ってたし店に並べた途端すぐ売れたりするのかと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_07020023")

-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:あれの価値の分かる人が来てくれれば絶対に売れるはずなんですけどね…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020024")

-- ▼直接出力
PlayPartVoice("マルイル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:でも、店頭に並べてしばらく経ちますがなんの反応もなくて…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020025")

-- ▼直接出力
setup_small_camera_end()
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Worry")
-- ▲直接出力

	--★★マルイル★★:さすがにちょっと不安になってきました「お客様の願いを知れ」に沿っているはずですが
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020026")


	--★★マルイル★★:これさえあれば、と思っている人も大勢いるはずなんですが…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020027")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:おいおい、らしくないぞ目利きには自信があるんだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_07020028")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("マルイル", "悲しみ")
-- ▲直接出力

	--★★マルイル★★:そうなんですけど…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020029")

-- ▼直接出力
 --if is_active(RndCamera090) == false then
 --DontChangeRandomCamera(true)
 --on_camera(Camera002)
 --end
CloseTalkWindow()
EntryWalk(Actor003,Camera003,EntryData112021_03_04,CameraAssetBundleName112021_03,CameraPos112021_03_104)
setup_small_camera_start()
lookWeight = {0.6, 005, 0.7, 0.35}
lookat_delay_weight(Actor002, lookWeight,1)
keep_ik_lookat(Actor002, Actor003, "J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:あ！いらっしゃいませなにかお探しですか？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020031")

-- ▼直接出力
PlayPartVoice("市民_男1", "肯定3")
-- ▲直接出力

	--★★市民（男）★★:ああ、実は薬の素材を探していて…
	Talk(Actor003,"NPCNAME_0271","speech","N","CO_101062_07020032")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("市民_男1", "驚き")
-- ▲直接出力

	--★★市民（男）★★:………！？
	Talk(Actor003,"NPCNAME_0271","speech","N","CO_101062_07020033")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力

	--★★マルイル★★:あ、そちらですか？お目が高い！このあいだ入荷したばかりでして――
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020034")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男1", "照れ")
-- ▲直接出力

	--★★市民（男）★★:まさかこんなところで売られているなんて！！あんた、これをいったいどうやって！？
	Talk(Actor003,"NPCNAME_0271","speech","N","CO_101062_07020035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:知り合いに腕利きの傭兵さんがいましてね<br>その方と一緒に取ってきたんです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020036")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:これってそんなにすごいものなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_07020037")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男1", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★市民（男）★★:もちろん！これは私が研究している薬を作るのに必要な素材なんだ！
	Talk(Actor003,"NPCNAME_0271","speech","N","CO_101062_07020038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:薬？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020039")

-- ▼直接出力
PlayPartVoice("市民_男1", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★市民（男）★★:ああ、一時的に肉体を強化する薬でな
	Talk(Actor003,"NPCNAME_0271","speech","N","CO_101062_07020040")


	--★★市民（男）★★:うまくいけば普通の人間でもバルバロイを倒せるようになるかもしれない
	Talk(Actor003,"NPCNAME_0271","speech","N","CO_101062_07020041")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それが本当なら凄いことだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_07020042")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("市民_男1", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★市民（男）★★:この稀少素材が店で手に入るなんて…私に全部売ってくれ！金ならいくらでも払う！
	Talk(Actor003,"NPCNAME_0271","speech","N","CO_101062_07020043")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "挨拶")
-- ▲直接出力

	--★★マルイル★★:は、はい！毎度あり！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020044")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男1", "笑い")
-- ▲直接出力

	--★★市民（男）★★:ありがとう！
	Talk(Actor003,"NPCNAME_0271","speech","N","CO_101062_07020045")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
lookat_delay_weight_reset(Actor002 , 1)
Hide(Actor003)
setup_small_camera_start(RndCamera001)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:よかったな、マルイル
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_07020047")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:は、はい。そうですね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020048")

	change_face(Actor002,"Sad")

	--★★マルイル★★:………
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_07020049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
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
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
