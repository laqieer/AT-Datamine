-- このluaスクリプトは、MA_01C112_14.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_007)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor003,Actor001)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor004,Actor001)
lookat_delay_weight(Actor001, 1.5, 0.5, 1.0, 0.5,1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:遅くなったが<br>この度の救援、感謝の意を述べておこう
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140002")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:謝辞にしてはずいぶんと尊大でありますな
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C112_140003")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ルーシャス★★:これは失礼<br>本心が透け出たようだ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:確かに余がそなたらの救援で<br>助かったのは事実といえば事実だが
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140005")


	--★★ルーシャス★★:余に刃を向けたのは他でもない<br>そなたらの王ではないか
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140006")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ケイ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ケイ★★:む…
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C112_140007")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "悩む")
-- ▲直接出力

	--★★マーリン★★:あなたに刃を向けたのは<br>アーサー様ではなく、魔女なのでは
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C112_140008")

-- ▼直接出力
lookat_delay_weight(Actor001, {0.8, 0, 0.5, 0.2} , 1.0)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
 --PlayPartVoice("ルーシャス", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ルーシャス★★:なんだと？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140009")

-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:ローマ軍は大量のバルバロイと<br>あなたを見限った魔女に襲われたと聞きます
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C112_140010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:恐らく、アーサー様は<br>あなたに興味を示していなかった
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C112_140011")

	change_face(Actor003,"Smile")

	--★★マーリン★★:違いますか？
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C112_140012")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★ルーシャス★★:………
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Sad")

	--★★ノワール★★:…アーサーはいったい<br>なにを考えてるんだ
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01C112_140015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力

	--★★ルーシャス★★:それは余も知りたいところだな<br>教えてくれまいか、宮廷魔術師殿
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140016")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マーリン★★:………
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C112_140017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:…さて、貴公の処遇についてだが
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C112_140018")


	--★★ケイ★★:実は退学届がアーサーの机の引き出しの奥に<br>埋もれていたせいで処理が済んでいなくてな
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C112_140019")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "驚き")
-- ▲直接出力

	--★★ルーシャス★★:書類仕事も満足にできないとは
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140020")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("マーリン", "落胆")
-- ▲直接出力

	--★★マーリン★★:これに関しては<br>弁明の余地もなく
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C112_140021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:幸い、退学との通知はしていないから<br>なんというか、その…
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C112_140022")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マーリン★★:そうですね<br>ぬるっと戻っていただければよいかと
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C112_140023")

	open_select_window_tag(Actor004,"Normal","MA_01C112_140024","MA_01C112_140025")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ノワール★★:いいのか？<br>そんな雑に処理してしまって
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01C112_140027")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ルーシャス★★:役所仕事を見ればその国の程度が知れる
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マーリン★★:…むしろ、これを見越して<br>アーサー様は隠していたのかもしれません
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C112_140029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:…学園で学ぶことで<br>ヤツに一泡吹かせてやれるかもしれぬ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140030")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:いささか腹立たしいが<br>今回はヤツの思惑に乗ってやる
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140031")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ノワール★★:というわけらしい<br>またよろしくな、ルーシャス
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01C112_140033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:…ふむ。まぁ、いいだろう
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:ただし、学園での生活を退屈に感じたら<br>余はひとりでもアーサー討伐に出撃する
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140035")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ルーシャス★★:せいぜい余を楽しませてくれ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140036")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ノワール★★:ところで、ヴェルナルス先生の容態は…
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01C112_140038")

-- ▼直接出力
lookat_delay_weight(Actor001, {0.8, 0, 0.5, 0.2} , 1.0)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)

 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:辛うじて一命はとりとめたようだ<br>この国の医療に期待する
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140039")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.45)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:まだまだ余の役に立ってもらわねばな<br>ヴェルナルスには?
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01C112_140040")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
