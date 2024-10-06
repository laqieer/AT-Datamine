-- このluaスクリプトは、MA_01B112_42.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110901_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力

	--★★ランスロット★★:贈り物とは<br>大変なものだな
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01B112_420003")


	--★★ノワール★★:…くれるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_420005")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Anger")

	--★★ガラハッド★★:寝ぼけるな<br>ガラハッドたちが贈るんだ
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B112_420007")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_420008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:街の子供たちに配るプレゼントを<br>買い出しに行ってたのよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_420009")

	PlayAction(Actor005,"to  Std_Surp")
	change_face(Actor005,"Smile")

	--★★ガラハッド★★:ガラハッドは荷物持ちとして同行した！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B112_420010")

	PlayAction(Actor004,"to  Std_Surp")

	--★★ディナタン★★:兄さんたちは疲れてるだろうから<br>ゆっくりしてもらおうと思ってたんだけど…
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01B112_420011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:せっかくの祭りだ<br>ノワールもランスロットも混ぜてやろう！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B112_420012")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ガラハッドがノワールたちと<br>絡みたいだけじゃないの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_420014")

	PlayAction(Actor005,"to  Std_Surp")
	change_face(Actor005,"Surprise")

	--★★ガラハッド★★:かっ、絡むとはなんだ！<br>不潔なこと言うな！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B112_420015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:不潔かなあ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_420016")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ディナタン★★:ほかの円卓のみなさんも<br>手分けしてプレゼントを配ってくれているの
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01B112_420017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ガウェインはロンディニウム<br>トリスタンはコーンウォールまで行ってくれてる
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_420018")


	--★★ディナタン★★:帰り道で決めた担当割を<br>あらためて発表しますね
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01B112_420019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:私とギネヴィア様は市街の中央広場<br>ランス兄ちゃんは居住区南側
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01B112_420020")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ディナタン★★:ガラハッドはマーケット周辺にいる<br>子供たちにプレゼントを配りましょう
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01B112_420021")

	open_select_window_tag(Actor001,"Normal","MA_01B112_420022","MA_01B112_420023")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:あの…俺はなにをすれば？<br>役割を教えられてないんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_420025")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ディナタン★★:兄さんは<br>プレゼントを包装する係
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01B112_420026")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_420027")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:子供たち、喜ぶだろうな<br>俺にも協力させてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_420029")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:とーぜん、頭数に入れてあるわよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_420030")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ディナタン★★:包装してないプレゼントがたくさんあるから<br>兄さんはそれをドンドン包んでいって
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01B112_420031")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…えっ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_420032")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ログレスには子供が多いでしょ<br>プレゼントもとても１回じゃ配り切れない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_420034")


	--★★ギネヴィア★★:ここと担当箇所とを往復して配ることになるわ<br>私たちが配っているあいだ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_420035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:あなたは隣の部屋に山積みされているプレゼントを<br>ドンドン包装していってほしいの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_420036")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…いや、あの
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_420037")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:さあ、<ruby=パーティ>作戦</ruby>開始よ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_420038")

-- ▼直接出力
--フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
Hide(Actor004)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ガラハッド★★:ここだけのハナシ
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B112_420040")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ガラハッド★★:ほとんどのプレゼントは包装し終えてある<br>残るは細かい小分けのものだけだ
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B112_420041")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？<br>じゃあ俺のやることは──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_420042")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:もちろん<br>お前の仕事はまだある
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01B112_420043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ランスロット★★:終わったら残った時間で<br>ゆっくり祭りを楽しむことだ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01B112_420045")

	PlayAction(Actor005,"to  Std_Joy")
	change_face(Actor005,"Smile")

	--★★ガラハッド★★:なんなら<br>手伝いに来てくれてもいいぞ
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B112_420047")

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
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
