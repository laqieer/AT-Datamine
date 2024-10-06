-- このluaスクリプトは、MA_01B109_32.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_02","110011_02_h")
Include("content_adv_advsmall_110011_02","Template110011_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",180.16,CharaPos110011_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_02,CameraPos110011_02_005)
	InitializeTemplateRandomCamera110011_02()
	InitializeTemplate110011_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:継承者ドノにご報告っ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01B109_320002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:すぐに里帰りできるようにしてやっからな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01B109_320003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ラグネル★★:ロンディニウムは奪い返した<br>あとはカレドニアだけだよ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01B109_320004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:結局ペテンだったンだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01B109_320005")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ガウェイン★★:ロンディニウムを襲ったのはバルバロイだった<br>…ルーシャスがけしかけたんだ、間違いねえ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01B109_320006")


	--★★ガウェイン★★:あそこから避難してきた人たちの誤解が<br>解ききれたわけじゃねえが…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01B109_320007")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:島の南を抑えられたのはデケエ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01B109_320008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","MA_01B109_320009","MA_01B109_320010","MA_01B109_320011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:なにが狙いで…？<br>自国民を犠牲にする理由がどこにある？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B109_320013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:それがわかりゃあな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01B109_320014")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ラグネル★★:あそこで戦った敵の中に魔女のひとりでもいれば<br>とっちめて吐かせることもできたんだろうけど…
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01B109_320015")

	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:どうせ、ろくなコト吐きやしなかっただろうぜ<br>なにが狙いだろうと…俺はやるだけだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01B109_320017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ノワール★★:町に被害は？<br>ロンディニウム民たちに帰れる場所はあるのか？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B109_320019")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラグネル★★:建物の損壊とかは<br>そこまで酷くないけど…
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01B109_320020")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:そもそも避難できた人たちが<br>そこまで多くねえんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01B109_320021")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★ラグネル★★:…町に帰ったとしても<br>なにももとどおりになんかなんないよ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01B109_320022")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ノワール★★:ガウェイン、ラグネル<br>無事でなによりだよ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B109_320024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:ギネヴィア殿下も張り切ってくれてね<br>助かったんだ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01B109_320025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:あとアイツな、飛び入りで参加してきたヤツ<br>エレ、エレ………なんだっけ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01B109_320026")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ラグネル★★:エレイン、だっけ<br>すっごくすっごく強かった
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01B109_320027")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:だいたい、卑怯な手使うヤツらに負けっかよ<br>悪評バラ巻いたり、汚ぇよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01B109_320028")

	goto Block1end

::Block1end::
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:止めよう<br>必ず、一刻も早く
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B109_320030")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:バルバロイもソレ使うヤツらも<br>ぜんぶまとめてな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01B109_320031")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラグネル★★:もうこれ以上こんなこと<br>…イヤだもんね
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01B109_320032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ラグネル★★:どんな理由があったとしても、許せないよ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01B109_320034")

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
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
