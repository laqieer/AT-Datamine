-- このluaスクリプトは、CO_101015_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",200,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_008)
	Camera003 = SetTemplate("Actor003",20,CharaPos110051_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_006)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:参ったな。ホットドッグの話を聞いたら<br>また食べたくなってしまった！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02020002")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★アーサー★★:よし、ノワール！俺のことは<br>ひとついい感じに誤魔化しておいてくれ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_02020003")

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor003)
Hide(Actor002)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:は？誤魔化すって――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02020005")

-- ▼直接出力
setup_small_camera_end(Camera001)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:…む？<br>アーサーを見なかったかね
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020007")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.5, 0.08, 0.8, 0.6} , 1)
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:（誤魔化すって、こいつをか…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101015_02020008")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:もしや、貴公は何か知っているのか？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101015_02020011","CO_101015_02020012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、わからない<br>全然、サッパリ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02020014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:本当だろうな？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020015")

	change_face(Actor003,"Normal")

	--★★ケイ★★:もしその証言が虚偽のものであった場合<br>貴公にはそれなりの罰を受けてもらうが？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020016")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:えっ…えっと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02020017")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:今一番罰を受けるべきは<br>やるべき仕事を放り出している者だがな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020018")

	change_face(Actor003,"Normal")

	--★★ケイ★★:おおかた、また城下町に出て<br>Ｂ級グルメなどを食べているに違いない
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020019")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ケイ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:まったく、あいつは…！
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あ…ホットドッグを食べに行くって<br>すぐに戻るらしいけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02020022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ケイ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ケイ★★:な、なんだと！？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020023")

	change_face(Actor003,"Anger")

	--★★ケイ★★:片付けるべき公務は山積みだというのに！<br>なにを考えている！？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020024")

-- ▼直接出力
PlayPartVoice("ケイ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ケイ★★:このあいだもすぐ戻ると言って<br>夕方まで帰ってこなかったのだ！
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020025")

	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Anger")

	--★★ケイ★★:だいたい、あいつはいつも…！
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020026")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ケイ★★:そんなにＢ級グルメを食べたければ<br>せめて誰かに買いに行かせればいいだろう
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020028")


	--★★ケイ★★:ひとりでふらふら街に出てばかりいては<br>王としての威厳がなくなるとあれほど…！
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:あ…それじゃ、俺はこれで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02020031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:待ちたまえ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020032")


	--★★ケイ★★:先日は、愚弟がずいぶん世話になったようだな<br>並んでホットドッグを食べたとか？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020033")


	--★★ケイ★★:あの日は仕事が立て込んでいたというのに<br>まさか貴公と遊び呆けていたとは…
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020034")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、あれはたまたまというか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02020035")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:問答無用。貴公には責任を取ってもらう
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020036")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:せ、責任！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02020037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "怒り")
-- ▲直接出力

	--★★ケイ★★:速やかにアーサーを連れ戻してこい<br>これは重大な公務だ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_02020038")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（…目が血走ってる<br>仕事が立て込んでるって言ってたな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101015_02020039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…わかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_02020040")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_アーサー_ランクアップ2_3")
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
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
