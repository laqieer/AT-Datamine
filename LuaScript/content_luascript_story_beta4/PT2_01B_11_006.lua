-- このluaスクリプトは、PT2_01B_11_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★パーシヴァル★★:まったく、勘弁してもらいたいね
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_11_0060002")


	--★★パーシヴァル★★:先月は果てなき森くんだりまで行かされて<br>今度は雪山ときた
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_11_0060003")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★パーシヴァル★★:これで聖杯が手に入らなかったら<br>さすがのぼくも我慢の限界だよ
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_11_0060004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:キザ男！<br>姉上のことが信じられないと言うのか！？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT2_01B_11_0060005")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Anger")

	--★★パーシヴァル★★:そうは言ってないだろう！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_11_0060006")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、おいおい…<br>ケンカしてる場合じゃないだろ、ふたりとも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0060007")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★パーシヴァル★★:ぼくだって<br>今回は見つかる可能性が高いと思っている
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_11_0060008")


	--★★パーシヴァル★★:だが、スノードンの山道はかなり険しく<br>登るだけでも一苦労だと聞く
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_11_0060009")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★パーシヴァル★★:そんな場所で物量に勝るローマ軍とぶつかれば<br>苦戦を強いられることは間違いない
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_11_0060010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力

	--★★ガラハッド★★:どんな敵が相手だとしても<br>ガラハッドは後れを取るつもりはない！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT2_01B_11_0060011")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Serious")

	--★★パーシヴァル★★:銀卓騎士団が相手でもかい？
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_11_0060012")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:そ、それは…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT2_01B_11_0060013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力

	--★★パーシヴァル★★:頼りにならない仲間をかばいながら<br>ローマ軍を相手にさせられるのは勘弁願いたいね
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_11_0060014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★パーシヴァル★★:戦う自信がないなら<br>厩舎で大人しくしているべきだよ、じゃじゃ馬娘
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_11_0060015")


	--★★ノワール★★:（パーシヴァルなりに気を使っているのか…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT2_01B_11_0060016")

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
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
